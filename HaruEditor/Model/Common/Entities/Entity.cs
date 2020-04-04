using OrangeNBT.NBT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaruEditor.Model.Common.Entities
{
    public abstract class Entity
    {
        public TagString Id { set; get; }

        public TagList Rotation { set; get; }

        public TagFloat FallDistance { set; get; }

        public TagShort Fire { set; get; }

        public TagShort Air { set; get; }

        public TagByte OnGround { set; get; }

        public TagByte NoGravity { set; get; }

        public TagString CustomName { set; get; }

        public TagByte CustomNameVisible { set; get; }

        public TagByte Silent { set; get; }

        public TagList Passengers { set; get; }

        public TagByte Glowing { set; get; }

        public TagList Tags { set; get; }
    }
}
