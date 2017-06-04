#ifndef activation_h
#define activation_h

#include <fmt/format.h>
#include <rapidjson/document.h>
#include <fstream>
#include <mib/typedefs.h>
//#include "settings.h"

using namespace rapidjson;
using namespace std;

namespace Rest
{
   struct Agent
   {
         Agent() = default;
         Agent(cchar* _name) : m_name(_name) { }
         Agent(cchar* _id, cchar* _name, cchar* _pin) : m_id(_id), m_name(_name), m_pin(_pin) { }

         ///void load_database();

         string& id() { return m_id; }
         void  set_id(cchar* _id)         { m_id = _id; }
         void  set_id(string&& _id)       { m_id = std::move(_id); }
         void  set_id(const string& _id)  { m_id = _id; }

         string& imei() { return m_imei; }
         void  set_imei(cchar* _imei)         { m_imei = _imei; }
         void  set_imei(string&& _imei)       { m_imei = std::move(_imei); }
         void  set_imei(const string& _imei)  { m_imei = _imei; }

         string& pin() { return m_pin; }
         void  set_pin(cchar* _pin)         { m_pin = _pin; }
         void  set_pin(string&& _pin)       { m_pin = std::move(_pin); }
         void  set_pin(const string& _pin)  { m_pin = _pin; }

         string& name() { return m_name; }
         void  set_name(cchar* _name)         { m_name = _name; }
         void  set_name(string&& _name)       { m_name = std::move(_name); }
         void  set_name(const string& _name)  { m_name = _name; }

         bool is_registered() { return m_is_registered; }
         void register_agent(bool b = true) { m_is_registered = b; }

         bool operator==(const Agent&);

      private:
         string m_id, m_name, m_pin, m_imei;
         bool m_is_registered;

   };

   template <typename> struct AgentRet;
   template<> struct AgentRet<const Agent&> { using type = const Agent&; };
   template<> struct AgentRet<Agent&> { using type = Agent&; };
   template<> struct AgentRet<Agent>  { using type = Agent; };

   struct Client
   {
         Client() = default;
         Client(cchar* _name) : m_name(_name) { }
         Client(cchar* _id, cchar* _name, cchar* _code) : m_id(_id), m_name(_name), m_code(_code) { }

         //void load_database();

         void add_agent(Agent&&);
         void add_agent(const Agent&);

         int agent_index(cchar*);
         int agent_index(const string&);

         /// only use if u are sure the target exists
         /// If NOT Combination of agent_index(id) and get_agent(index) will suffice
         Agent& get_agent(cchar* _id)
         { return m_agents[agent_index(_id)]; }

         Agent& get_agent(const string& _id)
         { return m_agents[agent_index(_id)]; }

         Agent& get_agent(uint _index) { return m_agents[_index]; }
         vector<Agent>& agents()       { return m_agents; }

         inline size_t size() { return m_agents.size(); }

         void clear() { vector<Agent> tmp; tmp.swap(m_agents); }

         bool exists(Agent&& );
         bool exists(const Agent&);
         bool exists(const string&);

         int  position() { return m_pos; }
         void set_position(int _pos) { m_pos = _pos; }

         string& code() { return m_code; }
         void  set_code(cchar* _code)         { m_code = _code; }
         void  set_code(string&& _code)       { m_code = std::move(_code); }
         void  set_code(const string& _code)  { m_code = _code; }

         string& id() { return m_id; }
         void  set_id(cchar* _id)         { m_id = _id; }
         void  set_id(string&& _id)       { m_id = std::move(_id); }
         void  set_id(const string& _id)  { m_id = _id; }

         string& name() { return m_name; }
         void  set_name(cchar* _name)         { m_name = _name; }
         void  set_name(string&& _name)       { m_name = std::move(_name); }
         void  set_name(const string& _name)  { m_name = _name; }

         bool is_registered() { return m_is_registered; }
         void register_client(bool b = true) { m_is_registered = b; }

         bool operator==(const Client&);

      private:
         string m_id, m_name, m_code;
         Agent  m_agent_tmp;
         int    m_pos;
         bool   m_is_registered;
         vector<Agent> m_agents;
   };

   struct Clients_database
   {
         enum class ClearMode { Agents, Both, Clients };
         enum class SearchMode { Agent, Client };
         enum class DatabaseStatus { Built, Loaded, Modified, Undefined, Updated };

         Clients_database() = default;
         Clients_database(cchar* _db_name) : m_db_name(_db_name) { }

         void add_client(cchar*);
         void add_client(Client&& );
         void add_client(const Client& );
         void add_agent(cchar* , cchar*);

         void build_client();
         void build_client(Document& );

         void clear();
         //void clear(ClearMode);
         int  client_index(const string&);

         inline size_t size() { return m_clients.size(); }


         Client& get_client(int _index) { return m_clients[_index]; }

         Client& get_client(cchar*);
         Client& get_client(const string&);

         vector<Client>& clients() { return m_clients; }

         bool exists(string&& _client_id)      { return client_index(_client_id) >= 0; }
         bool exists(const string& _client_id) { return client_index(_client_id) >= 0; }
         bool exists(Client&&);
         bool exists(const Client&);

         void load_database() { load_database("data/clients"); }
         void load_database(cchar*);
         void load_database(const string& _fname) { load_database(_fname.data()); }

         DatabaseStatus database_status() { return m_db_status; }
         void           set_database_status(DatabaseStatus _status) { m_db_status = _status; }

         void update_database();

      private:
         string m_db_name = "data/clients";
         Document root;
         vector<Client> m_clients;
         Client m_tmp_client;
         DatabaseStatus m_db_status = DatabaseStatus::Undefined;
   };

   static Clients_database clients_db;
   void   init_database(Clients_database& cldb = clients_db);

}

#endif//activation_h
