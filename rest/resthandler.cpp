
#include "resthandler.h"

#include <Poco/StreamCopier.h>
#include <mib/timer>
#include <fmt/ostream.h>

using namespace fmt;
using namespace mvc_utils;
using namespace std;
using namespace Poco;
using namespace Poco::Net;

namespace Rest
{
   void RestHandler::register_agent(HTTPServerRequest& request, HTTPServerResponse& response, std::ostream& ostr)
   {
      init_database();
      try
      {
         int index = clients_db.client_index(request.get("client_id"));

         if (index >=0) /// Client Exists
         {
            Client& clients = clients_db.get_client(index);
            int index_ag = clients.agent_index(request.get("agent_id"));
            if (index_ag >= 0) /// Agent Exists
            {
               Agent& ag = clients.get_agent(index_ag);
               if (ag.imei() == request.get("imei"))
                  ostr << R"({"status": 200, "message": "Device already registered"})";
               else
               {
                  Client cl;
                  cl.set_id(request.get("client_id"));
                  cl.set_name(request.get("client_name"));

                  Agent ag;
                  ag.set_id(request.get("agent_id"));
                  ag.set_imei(request.get("imei"));

                  cl.add_agent(ag);
                  clients_db.add_client(cl);
                  clients_db.update_database();

                  ostr << R"({"status": 200, "message": "Device successfully registered"})";
               }
            }
         }
         else
            fmt::print(ostr,
                       "{{{}\"{}\"}}\n", R"("status":400, "message": "Client NOT registered", "client_id": )",
                       request.get("client_id"));

      }
      catch (Poco::Exception& exp)
      {
         fmt::print("{}\n", exp.displayText());
         fmt::print(ostr,
                    "{{{}{}\"}}\n", R"("status":400, "message": "Header parameter )",
                    exp.displayText());
      }

   }

   void RestHandler::register_client(HTTPServerRequest& request, HTTPServerResponse& response, std::ostream& ostr)
   {
      init_database();
      try
      {
         int index = clients_db.client_index(request.get("client_id"));

         if (index == -1) /// Client doesn't exists
         {
            Client& client = clients_db.get_client(index);
            clients_db.add_client(client);
            ostr << R"({"status": 400, "message": "Client Successfully Registered"})";
         }
         else /// Client Exists, don't Register
         {
            ostr << R"({"status": 400, "message": "Client Already Registered"})";
         }

      }
      catch (Poco::Exception& exp)
      {
         fmt::print("{}\n", exp.displayText());
         fmt::print(ostr,
                    "{{{}{}\"}}\n", R"("status":400, "message": "Header parameter )",
                    exp.displayText());
      }
   }

   void RestHandler::handleRequest(HTTPServerRequest& request, HTTPServerResponse& response)
   {
      fmt::print("from: {} \t\t to: {}\n",
                 request.clientAddress().toString(),
                 request.serverAddress().toString());

      response.setChunkedTransferEncoding(true);
      //response.setContentType("text/html");

      ostream& ostr    = response.send();
      string&  str_req = request.getURI();

      timer tm(timer::init_mode::immediate);

      if (request.getMethod() == "POST" && str_req == "/api/firsttime/pos/agent")
      {
         register_agent(request, response, ostr);
      }

      else if (str_req == "/api/firsttime/pos/client")
      {
         register_client(request, response, ostr);
      }

      else
      {
         ostr << R"({ "status":404, "message": "Are u lost?" })";
      }

      fmt::print("\nTook {} μs\n",
                 tm.time_elapsed_w_end());

   }

}
