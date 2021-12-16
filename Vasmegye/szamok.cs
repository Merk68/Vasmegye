using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vasmegye
{
  class szamok
  {
    private int szulesnem;

    public int Szulesnem
    {
      get { return szulesnem; }
      set { szulesnem = value; }
    }
    private int szamok2;

    public int Szamok2
    {
      get { return szamok2; }
      set { szamok2 = value; }
    }
    private int szamok3;

    public int Szamok3
    {
      get { return szamok3; }
      set { szamok3 = value; }
    }

    public szamok(int szulesnem, int szamok2, int szamok3)
    {
      this.szulesnem = szulesnem;
      this.szamok2 = szamok2;
      this.szamok3 = szamok3;
    }
  }
}
