using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class richconfig:builder
    {
        private persona persona = new persona();
        public override void setweapon()
        {
            persona.weapon = "titan sword";
        }

        public override void setpictures()
        {
            persona.pictures = Image.FromFile("C:\\Users\\minAd\\Desktop\\constract\\builder\\WindowsFormsApp1\\rich.jpg");
        }

        public override void setarmor()
        {
            persona.armor = "titan armor";
        }

        public override void setamulet()
        {
            persona.amulet = "amulet of immortality";
        }

        public override void setring()
        {
            persona.ring = "ring of power over fire";
            persona.ring += "ring of power over frost";
            persona.ring += "ring of power over lightning";
        }

        public override void setsubweapon()
        {
            persona.subweapon = "titan bow";
            persona.subweapon += "titan knife";
        }

        public override void setpotions()
        {
            persona.potions = "god health potions ";
            persona.potions += "god speed potions ";
            persona.potions += "god defense potions ";
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
