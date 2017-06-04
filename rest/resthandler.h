
#include <Poco/Net/HTTPRequestHandler.h>
#include <Poco/Net/HTTPServerRequest.h>
#include <Poco/Net/HTTPServerResponse.h>

#include <mib/timer>
#include <mib/typedefs.h>
#include <fmt/format.h>

#include "activation.h"

using namespace Poco;
using namespace Poco::Net;

namespace Rest
{
   struct RestHandler : public HTTPRequestHandler
   {
         RestHandler()
         {
         }
         inline void log();
         void handleRequest(HTTPServerRequest&, HTTPServerResponse&) override;

         //clients_database& clients() { return m_clients_database; }

         void register_agent(HTTPServerRequest&,  HTTPServerResponse&, std::ostream&);
         void register_client(HTTPServerRequest&, HTTPServerResponse&, std::ostream&);

      private:

   };

}

