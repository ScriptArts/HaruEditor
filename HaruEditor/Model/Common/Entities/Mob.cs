using OrangeNBT.NBT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaruEditor.Model.Common.Entities
{
    public abstract class Mob : Entity
    {
        public TagFloat Health { set; get; }

        public TagFloat AbsorptionAmount { set; get; }

        public TagShort HurtTime { set; get; }

        public TagInt HurtByTimestamp { set; get; }

        public TagShort DeathTime { set; get; }

        public TagByte FallFlying { set; get; }

        public TagList Attributes { set; get; }

        public TagList ActiveEffects { set; get; }

        public TagList HandItems { set; get; }

        public TagList ArmorItems { set; get; }

        public TagList HandDropChances { set; get; }

        public TagList ArmorDropChances { set; get; }

        public TagString DeathLootTable { set; get; }

        public TagLong DeathLootTableSeed { set; get; }

        public TagByte CanPickUpLoot { set; get; }

        public TagByte NoAI { set; get; }

        public TagByte PersistenceRequired { set; get; }

        public TagByte LeftHanded { set; get; }

        public TagString Team { set; get; }

        public TagByte Leashed { set; get; }

        public TagCompound Leash { set; get; }
    }
}
