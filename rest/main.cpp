
#include <iostream>
#include <fmt/format.h>
#include "server.h"

using namespace fmt;
using namespace Rest;
using namespace std;

int main()
{
   Rest::settings().open_file("ls");
   return 0;
}

