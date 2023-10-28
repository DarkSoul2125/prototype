using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class mediumconfig:builder
    {
        private persona persona = new persona();
        public override void setweapon()
        {
            persona.weapon = "steel sword";
        }

        public override void setpictures()
        {

            persona.pictures = Image.FromFile("C:\\Users\\minAd\\Desktop\\constract\\builder\\WindowsFormsApp1\\medium.jpg");
        }

        public override void setarmor()
        {
            persona.armor = "steel armor";
        }

        public override void setamulet()
        {
            persona.amulet = "amulet of power";
        }

        public override void setring()
        {
            persona.ring = "ring of power over fire";
        }

        public override void setsubweapon()
        {
            persona.subweapon = "steel bow";
            persona.subweapon += "gold knife";
        }

        public override void setpotions()
        {
            persona.potions = "big health potions ";
            persona.potions += "big speed potions ";
            persona.potions += "big defense potions ";
        }

        public override persona build()
        {
            setweapon();
            setarmor();
            setamulet();
            setring();
            setpictures();
            setsubweapon();
            setpotions();
            return persona;
        }
    }
}
