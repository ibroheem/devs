
#define RAPIDJSON_HAS_STDSTRING 1

#include "activation.h"

#include <rapidjson/stringbuffer.h>
#include <rapidjson/prettywriter.h>

using namespace std;
using namespace rapidjson;

namespace Rest
{

   bool Agent::operator==(const Agent& rhs)
   {
      return ((m_id == rhs.m_id) && (m_imei == rhs.m_imei));
   }

   void Client::add_agent(Agent&& _agent)
   {
      if (!exists(_agent))
         m_agents.push_back(_agent);
   }

   void Client::add_agent(const Agent& _agent)
   {
      if (!exists(_agent))
         m_agents.push_back(_agent);
   }

   bool Client::exists(const Agent& _agent)
   {
      for(Agent& ag : m_agents)
      {
         if (ag == _agent)
            return true;
      }
      return false;
   }

   int Client::agent_index(cchar* _id)
   {
      for(size_t i = 0; i < m_agents.size(); ++i)
      {
         if (m_agents[i].id() == _id)
            return i;
      }
      return -1;
   }

   int Client::agent_index(const string& _id)
   {
      return agent_index(_id.data());
   }

   bool Client::operator==(const Client& rhs)
   {
      return ((m_id == rhs.m_id));// && (m_code == rhs.m_code));
   }

   void Clients_database::add_client(cchar* _fname)
   {

   }

   void Clients_database::add_client(Client&& _client)
   {
      if (!exists(_client))
         m_clients.push_back(std::move(_client));
   }

   void Clients_database::add_client(const Client& _client)
   {
      if (!exists(_client))
         m_clients.push_back(_client);
   }

   void Clients_database::build_client()
   {
      build_client(root);
   }

   void Clients_database::build_client(Document& _root)
   {
      if (_root.HasMember("clients"))
      {
         Value& all_clients = _root["clients"];
         Client cl;
         Agent  ag;
         uint agents = 0;

         clear();

         for (Value& _clients : all_clients.GetArray())
         {
            cl.set_id(_clients["id"].GetString());
            cl.set_code(_clients["code"].GetString());
            cl.set_name(_clients["name"].GetString());
            cl.register_client(_clients["registered"].GetBool());

            Value& client_agents = _clients["agents"];
            for (Value& _agent : client_agents.GetArray())
            {
               ag.set_id(_agent["id"].GetString());
               ag.set_imei(_agent["imei"].GetString());
               ag.set_name(_agent["name"].GetString());
               ag.set_pin(_agent["pin"].GetString());

               cl.add_agent(ag);
               Agent& ag1 = cl.get_agent(ag.id());
               ++agents;
               fmt::print("\tagent{}: \n\t\tid:\t{}\n\t\timei:\t{}\n",
                          agents,
                          ag1.id(),
                          ag1.imei());

            }

            add_client(cl);
            cl.clear();
         }
         set_database_status(DatabaseStatus::Built);
      }
   }

   void Clients_database::clear()
   {
      for (Client& cl : m_clients)
         cl.clear();

      vector<Client> tmp;
      tmp.swap(m_clients);
   }

   int Clients_database::client_index(const string& _id)
   {
      for(size_t i = 0; i < m_clients.size(); ++i)
      {
         if (m_clients[i].id() == _id)
            return i;
      }
      fmt::print("{}\t{}\n", m_clients.size(), _id);
      return -1;
   }

   bool Clients_database::exists(const Client& _client)
   {
      for(Client& cl : m_clients)
      {
         if (cl == _client)
            return true;
      }
      return false;
   }

   Client& Clients_database::get_client(cchar* _client_id)
   {
      Document::MemberIterator iter = root.FindMember(_client_id);
      if (iter != root.MemberEnd())
      {
         for (Client& c : m_clients)
         {
            if (c.id().compare(_client_id))
               return c;
         }
      }
      return m_tmp_client;
   }

   Client& Clients_database::get_client(const string& _client_id)
   {
      return get_client(_client_id.c_str());
   }

   void Clients_database::load_database(cchar*_fname)
   {
      ifstream ifs(_fname, ifstream::openmode::_S_in);
      string data;
      if (ifs.is_open())
      {
         string tmp;
         while (!ifs.eof())
         {
            getline(ifs, tmp);
            data += tmp;
         }

         set_database_status(DatabaseStatus::Loaded);
         root.Parse(data.c_str());
      }
   }

   void Clients_database::update_database()
   {
      using namespace rapidjson;

      Document doc;
      doc.SetObject();
      Document::AllocatorType& allocator = doc.GetAllocator();

      Value clients(kArrayType);

      for (Client& cl : m_clients)
      {
         Value val_client(kObjectType);    // Null
         val_client.AddMember(StringRef("name"), StringRef(cl.name()), allocator);
         val_client.AddMember(StringRef("id"), StringRef(cl.id()),     allocator);
         val_client.AddMember(StringRef("code"), StringRef(cl.code()), allocator);

         Value agents(kArrayType);

         for(Agent& ag : cl.agents())
         {
            Value agent(kObjectType);
            agent.AddMember("id",   StringRef(ag.id()),   allocator);
            agent.AddMember("imei", StringRef(ag.imei()), allocator);
            agents.PushBack(agent, allocator);
         }
         val_client.AddMember("agents", agents, allocator);
         clients.PushBack(val_client, allocator);
      }

      doc.AddMember("clients", clients, allocator);

      StringBuffer buffer;
      PrettyWriter<StringBuffer> writer(buffer);
      doc.Accept(writer);

      ofstream ("clients.update") << buffer.GetString();
   }

   void init_database(Clients_database& cldb)
   {
      switch(cldb.database_status())
      {
         case Clients_database::DatabaseStatus::Built:
         break;

         case Clients_database::DatabaseStatus::Loaded:
            cldb.build_client();
         break;

         case Clients_database::DatabaseStatus::Modified:
         case Clients_database::DatabaseStatus::Undefined:
            cldb.load_database();
            cldb.build_client();
         break;

         default:
         break;
      }
   }

}
