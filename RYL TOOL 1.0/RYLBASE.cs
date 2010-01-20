using System;
using System.Collections.Generic;
using System.Text;

namespace RYL_TOOL
{
    class RYLBASE
    {
        private int lvl;
        private int bonusPoints;
        private int str, con, dex, inte, wis;


        public virtual int Str
        {
            get { return str; }
            set { str = value; }
        }

        public virtual int Con
        {
            get { return con; }
            set { con = value; }
        }

        public virtual int Dex
        {
            get { return dex; }
            set { dex = value; }
        }

        public virtual int Inte
        {
            get { return inte; }
            set { inte = value; }
        }

        public virtual int Wis
        {
            get { return wis; }
            set { wis = value; }
        }

        public int Lvl
        {
            get { return lvl; }
            set { lvl = ((value > 0) ? value : 0); }
        }

        public int BonusPoints
        {
            get { return bonusPoints; }
            set { bonusPoints = ((value > 0) ? value : 0); }
        }


        public RYLBASE()
        {
            Lvl = 0;
        }

        public RYLBASE(int lv)
        {
            Lvl = lv;
        }


        public void calculaBonusPoints()
        {
            if (Lvl < 10)
            {
                BonusPoints = 0;
            }
            else
            {
                BonusPoints = ((Lvl - 1) * 4) + 10;
            }
        }

        public virtual int calcDiferencaBPointsSTR(int newStat, int fixStat)
        {
            return 0;
        }
        public virtual int calcDiferencaBPointsCON(int newStat, int fixStat)
        {
            return 0;
        }
        public virtual int calcDiferencaBPointsDEX(int newStat, int fixStat)
        {
            return 0;
        }
        public virtual int calcDiferencaBPointsINT(int newStat, int fixStat)
        {
            return 0;
        }
        public virtual int calcDiferencaBPointsWIS(int newStat, int fixStat)
        {
            return 0;
        }


        public virtual int maxSTR()
        {
            return 0;
        }
        public virtual int maxCON()
        {
            return 0;
        }
        public virtual int maxDEX()
        {
            return 0;
        }
        public virtual int maxINT()
        {
            return 0;
        }
        public virtual int maxWIS()
        {
            return 0;
        }

        public virtual void calculaStats()
        {
        }

        public virtual int calculaStr()
        {
            return 0;
        }

        public virtual string exibeStr()
        {
            return "";
        }

        public virtual int calculaCon()
        {
            return 0;
        }

        public virtual string exibeCon()
        {
            return "";
        }
        
        public virtual int calculaDex()
        {
            return 0;
        }

        public virtual string exibeDex()
        {
            return "";
        }

        public virtual int calculaInt()
        {
            return 0;
        }

        public virtual string exibeInt()
        {
            return "";
        }

        public virtual int calculaWis()
        {
            return 0;
        }

        public virtual string exibeWis()
        {
            return "";
        }

        public override string ToString()
        {
            string composite = "" + BonusPoints;
            return composite;
        }
    }
}
