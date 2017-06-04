
#include "server.h"
#include "activation.h"

using namespace mvc_utils;
using namespace std;
using namespace Poco;
using namespace Poco::Net;
using namespace Poco::Util;

namespace Rest
{
   int HServer::main(const vector<string> &args)
   {
      UInt16 port = 9980;
      MyHTTPServerParams sparams;
      sparams.setMaxQueued(100);
      sparams.setMaxThreads(16);
      sparams.setSoftwareVersion("Custom Server");

      auto run_server = [&]()
      {
         //ServerSocket. ssocket(port);
         //ssocket.
         RequestHandler* reqhandler = new RequestHandler;

         HTTPServer server(reqhandler, port);//ŃŃ&sparams);
         server.start();

         fmt::print("Server Started!\n");
         waitForTerminationRequest();

         delete reqhandler;

         server.stop();
         return EXIT_OK;
      };
      try
      {
         run_server();
      }
      catch(Poco::Exception& e)
      {
         cout << e.displayText() << '\n';
         //if (e.displayText() == "I/O error: Permission denied")
         {
            //e.rethrow();
            port = 9980;
            throw run_server();
         }
      }
      return EXIT_FAILURE;
   }

}

int main(int argc, char** argv)
{
   ios_base::sync_with_stdio(false);

   //fmt::print("String Size: {}\n", sizeof(std::string));

   Rest::HServer hsrv;
   hsrv.run(argc, argv);
}
