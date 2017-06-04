#ifndef settings_h
#define settings_h

//#include <nlohmann/json-2.0.10.hpp>
#include <mib/typedefs.h>
#include <nlohmann/json-2.1.0.hpp>
#include <fstream>
//#include <embedded/estr.h>

using namespace std;
using namespace nlohmann;

bool sync_with_stdio = ios_base::sync_with_stdio(false);
//typedef basic_json<> json;

namespace Rest
{
   struct settings
   {
      public:
         enum class Depth { single, multi };

         settings(cchar*, Depth);

         bool  open_file(cchar* fname);

         Depth depth() { return m_depth; }

         string& file_name() { return m_fname; }

         void set_depth(Depth _depth)             { m_depth = _depth; }
         void set_file_name(cchar* _fname)        { m_fname = _fname; }
         void set_file_name(string&& _fname)      { m_fname = std::move(_fname); }
         void set_file_name(const string& _fname) { m_fname = _fname; }

      private:
         string m_fname;
         Depth  m_depth;
   };

   settings::settings(cchar* _file_name, Depth _depth) : m_fname(_file_name), m_depth(_depth)
   {
   }

   bool settings::open_file(cchar* fname)
   {
      bool ret = false;
      ifstream ifs(fname);
      ifs.tie(nullptr);
      if (ifs.is_open())
      {
         ret = true;
      }
      return ret;
   }
}

#endif//settings_h
