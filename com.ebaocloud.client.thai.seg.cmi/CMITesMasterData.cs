﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.ebaocloud.client.thai.seg.cmi.response;
using com.ebaocloud.client.thai.seg.cmi.api;

namespace com.ebaocloud.client.thai.seg.cmi
{
    class CMITesMasterData
    {
        //public static void Main(String[] args)
        //{
        //    MasterDataService service = new MasterDataServiceImpl();
        //    List<CascadeValue> result = service.GetVehicleMakes();

        //    List<CascadeValue> modelResult = service.GetVehicleMakeModels("TOYOTA");

        //    CascadeValue firstModel = (CascadeValue)modelResult[0];
        //    List<CascadeValue> modelsYears = service.GetVehicleModelYears("TOYOTA", firstModel.value);

        //    CascadeValue firstModelYear = (CascadeValue)modelsYears[0];
        //    List<VehicleModel> modelInfos = service.GetVehicleModelInfo("TOYOTA", firstModel.value, firstModelYear.value);

        //    List<KeyValue> vehicleUsages = service.GetVehicleUsage(((VehicleModel)modelInfos[0]).vehicleType);

        //    List<KeyValue> vehicleTypes = service.GetVehicleType();
        //    KeyValue firstVehicleType = (KeyValue)vehicleTypes[0];
        //    List<CascadeValue> vehicleSubTypes = service.GetVehicleSubType(firstVehicleType.key);

        //    List<KeyValue> vehicleGarageTypes = service.GetVehicleGarageType();
        //    List<KeyValue> vehicleCountries = service.GetVehicleCountry();
        //    List<KeyValue> vehicleColors = service.GetVehicleColor();
        //    List<KeyValue> beneficiaries = service.GetBeneficiary();
        //    List<KeyValue> occupations = service.GetOccupation();
        //    List<KeyValue> indiPrefixs = service.GetPrefix(PrefixType.INDIVIDUAL);
        //    List<KeyValue> cropPrefixs = service.GetPrefix(PrefixType.ORGANIZATION);
        //    List<KeyValue> customerTypes = service.GetCustomType();
        //    List<KeyValue> addressTypes = service.GetAddressType();
        //    List<KeyValue> countries = service.GetCounty();
        //    List<KeyValue> idTypes = service.GetIdType();



        //    List<CascadeValue> provinces = service.GetAddressProvince();
        //    CascadeValue firstProvince = provinces[1];
        //    List<CascadeValue> districts = service.GetDistrict(firstProvince.key);
        //    CascadeValue firstDistrict = districts[1];
        //    List<Address> subDistrict = service.GetSubDistrict(firstProvince.key, firstDistrict.key);

        //    Console.Write(modelInfos);
        //    Console.WriteLine();
        //}
    }
}
