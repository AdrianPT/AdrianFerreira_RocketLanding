﻿using RocketLanding_AFerreiraPT.Models;

namespace RocketLanding_AFerreiraPT.Factories.Interfaces
{
    public interface ISpaceVehicleModelFactory
    {
        public ISpaceVehicle GetSpaceVehicle(int id, SpaceType spaceType);

    }
}
