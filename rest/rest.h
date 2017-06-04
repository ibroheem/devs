#ifndef rest_h
#define rest_h

#include "settings.h"
#include "activation.h"

using namespace nlohmann;
using namespace std;

namespace Rest
{
   struct device_reg
   {
         device_reg() : m_imei() {}

         void register_device();
         bool registered() { return m_registered; }

         void set_client(cchar* _client)          { m_client = _client; }
         void set_client(string&& _client)        { m_client = std::move(_client); }
         void set_client(const string& _client)   { m_client = _client; }

         void set_imei(cchar*);
         void set_imei(const string&);

      private:
         char m_imei[19];
         string m_agent_name;
         string m_client;
         bool m_registered;
   };

   //void device_reg::

   void device_reg::set_imei(cchar* _imei)
   {
      //if (_imei)
         //estr::assign<sizeof m_imei>(m_imei, _imei);
   }

   void device_reg::set_imei(const string& _imei)
   {
      //estr::assign<sizeof m_imei>(m_imei, _imei.data());
   }
}

#endif//rest_h
