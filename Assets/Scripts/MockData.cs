using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MockData
{
    public static Dictionary<string, object> PRODUCT_1 = new Dictionary<string, object>()
    {
        { "ID", 1 },
        { "NAME", "Cool Product Name 1" },
        { "PRICE_TIER", "TIER_1" }
    };
    public static Dictionary<string, object> PRODUCT_2 = new Dictionary<string, object>()
    {
        { "ID", 2 },
        { "NAME", "Cool Product Name 2" },
        { "PRICE_TIER", "TIER_1" }
    };
    public static Dictionary<string, object> PRODUCT_3 = new Dictionary<string, object>()
    {
        { "ID", 3 },
        { "NAME", "Cool Product Name 3" },
        { "PRICE_TIER", "TIER_1" }
    };
    public static Dictionary<string, object> PRODUCT_4 = new Dictionary<string, object>()
    {
        { "ID", 4 },
        { "NAME", "Cool Product Name 4" },
        { "PRICE_TIER", "TIER_1" }
    };
    public static Dictionary<string, object> PRODUCT_5 = new Dictionary<string, object>()
    {
        { "ID", 5 },
        { "NAME", "Cool Product Name 5" },
        { "PRICE_TIER", "TIER_1" }
    };
    public static Dictionary<string, object> COMPANY_1 = new Dictionary<string, object>()
    {
        { "ID", 1 },
        { "NAME", "Cool Company Name 1" },
        { "REVIEW", 1 }
    };
    public static Dictionary<string, object> COMPANY_2 = new Dictionary<string, object>()
    {
        { "ID", 2 },
        { "NAME", "Cool Company Name 2" },
        { "REVIEW", 4 }
    };
    public static Dictionary<string, object> COMPANY_3 = new Dictionary<string, object>()
    {
        { "ID", 3 },
        { "NAME", "Cool Company Name 3" },
        { "REVIEW", 5 }
    };
    public static Dictionary<string, object> COMPANY_4 = new Dictionary<string, object>()
    {
        { "ID", 4 },
        { "NAME", "Cool Company Name 4" },
        { "REVIEW", 3 }
    };
    public static Dictionary<string, object> COMPANY_5 = new Dictionary<string, object>()
    {
        { "ID", 5 },
        { "NAME", "Cool Company Name 5" },
        { "REVIEW", 5 }
    };

    internal static Dictionary<string, object> GetProduct(int id)
    {
        switch (id)
        {
            case 1:
                return PRODUCT_1;
            case 2:
                return PRODUCT_2;
            case 3:
                return PRODUCT_3;
            case 4:
                return PRODUCT_4;
            case 5:
                return PRODUCT_5;
        }

        return null;
    }

    internal static Dictionary<string, object> GetCompany(int id)
    {
        switch (id)
        {
            case 1:
                return COMPANY_1;
            case 2:
                return COMPANY_2;
            case 3:
                return COMPANY_3;
            case 4:
                return COMPANY_4;
            case 5:
                return COMPANY_5;
        }

        return null;
    }
}

