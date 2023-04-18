﻿using CarRentalDalCore.DalApi.IEntityDal;
using CarRentalDalCore.DataObjects.Customer;
using CarRentalDalEF.CarRentalDBContext;
using CarRentalDalEF.EntityServiceBase;

namespace CarRentalDalEF.CarRentalDal;

public class DalCreditCardPayment : EntityServiceBase<CreditCardPayment, CarRentalDBContext>, ICreditCardPayment
{
}
