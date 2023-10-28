using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public abstract  class builder
    {
        public abstract void setweapon();
        public abstract void setarmor();
        public abstract void setamulet();
        public abstract void setring();
        public abstract void setsubweapon();
        public abstract void setpotions();
        public abstract void setpictures();
        public abstract persona build();
    }
    public class persona
    {
        public string weapon;
        public string armor;
        public Image pictures;
        public string amulet;
        public string ring;
        public string subweapon;
        public string potions;


        public persona()
        { }

        public persona(persona per)
        {
            this.weapon = per.weapon;
            this.armor = per.armor;
            this.amulet = per.amulet;
            this.ring = per.ring;
            this.subweapon = per.subweapon;
            this.potions = per.potions;
            this.pictures = per.pictures;   
        }

        public persona clone()
        { 
            return new persona(this);
        }
    }
}
