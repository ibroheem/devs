#ifndef server_h
#define server_h

#include <iostream>

//#include <Poco/Net/Socket.h>
//#include <Poco/Net/SocketAddress.h>
#include <Poco/Net/SocketStream.h>
#include <Poco/Net/StreamSocket.h>
#include <Poco/Util/ServerApplication.h>
#include <Poco/Net/HTTPServer.h>
#include <Poco/Net/HTTPRequestHandler.h>
#include <Poco/Net/HTTPServerRequest.h>
#include <Poco/Net/HTTPServerResponse.h>
#include <Poco/URI.h>

#include <mib/Poco/net>

//#include "rest.h"
#include "resthandler.h"

using namespace mvc_utils;
using namespace Poco;
using namespace Poco::Net;
using namespace Poco::Util;

namespace Rest
{
   struct RequestHandler : public HTTPRequestHandlerFactory
   {
      RequestHandler() = default;
      HTTPRequestHandler* createRequestHandler(const HTTPServerRequest& request) override
      {
         return new RestHandler();
      }
   };

   struct HServer : public ServerApplication
   {
         HServer() = default;

      protected:
         int main(const vector<string>&);
   };

   struct server
   {
         server();

         void set_host(cchar);
         void set_port();

         void start();
      private:
         //SocketAddress saddress;
   };

   void server::start()
   {

   }
}

#endif//server_h
