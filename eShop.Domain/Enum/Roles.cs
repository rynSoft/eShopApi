using System;

namespace eShop.Domain.Enum
{
    public enum Roles
    {
        SistemAdmin,
        Admin,
        Depo,
        Kullanici,
        Misafir
    }

    public static class Constants
    {
        public static readonly Guid SistemAdmin ;
        public static readonly Guid Admin;
        public static readonly string Depo;
        public static readonly string Misafir;

        public static readonly Guid SistemAdminUser ;
        public static readonly Guid VillaUser ;
      
    }
}
