﻿using CarRentalDalCore.DalApi.IEntityDal;
using CarRentalDalCore.DataObjects.Branch;
using CarRentalDalEF.CarRentalDBContext;
using CarRentalDalEF.EntityServiceBase;

namespace CarRentalDalEF.CarRentalDal;

public class DalBranch : EntityServiceBase<Branch, CarRentalDBContext.CarRentalDBContext>, IBranch
{
}
