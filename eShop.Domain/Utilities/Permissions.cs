using System;
using System.Collections.Generic;
using eShop.Domain.Entities;

namespace eShop.Domain.Utilities
{
    public static class Permissions
    {
        public static class Genel
        {
            public const string All = "Permissions.Genel.All";
        }
        public static class UretimBandi
        {
            public const string All = "Üretim Bandı";
        }
        public static class Etiketleme
        {
            public const string All = "Etiketleme";
        }
        public static class DisplayAssembly
        {
            public const string All = "Display Montajı";
        }
        public static class Programming
        {
            public const string All = "Programlama";
        }
        public static class DetachFromPanel
        {
            public const string All = "Panelden Ayırma";
        }
        public static class Test
        {
            public const string All = "Test";
        }

        public static class QualityProcesses
        {
            public const string All = "Kalite Süreçler";
        }

        public static class QualityApprovals
        {
            public const string All = "Kalite Onaylar";
        }

        public static class QualityOperations
        {
            public const string All = "Kalite Operasyonlar";
        }
        public static class WarehouseDescription
        {
            public const string All = "Depo Tanımları";
        }
        public static class LineDescription
        {
            public const string All = "Hat Tanımları";
        }
        public static class MachineDescription
        {
            public const string All = "Makine Tanımları";
        }

        public static class ShiftDescription
        {
            public const string All = "Vardiya Tanımları";
        }

        public static class Oee
        {
            public const string All = "Oee Gösterim";
        }

        public static class ShiftDefinitionProcess
        {
            public const string All = "Vardiya - Hat Hedef Miktar Tanımları";
        }

        public static class BreakDefinitions
        {
            public const string All = "Mola Tanımları";
        }



        public static class QualityCompletedOperations
        {
            public const string All = "Tamamlanan Kalite Operasyonları";
        }
        public static class UretimPlanlama
        {
            public const string All = "Üretim Planlama";
            public const string Goruntule = "Üretim Planlama Görüntüle";
            public const string Kaydet = "Üretim Planlama Kaydet";
            public const string Sil = "Üretim Planlama Sil";
        }
        public static class KitHazirlama
        {
            public const string All = "Kit Hazırlama";
        }
        public static class KitDogrulama
        {
            public const string All = "Kit Doğrulama";
        }
        public static class SetupVerification
        {
            public const string All = "Setup Verification";
        }
        public static class Ayarlar
        {
            public const string All = "Ayarlar";
        }
        public static class Credential
        {
            public const string All = "Credential";
        }

        public static class Kalite
        {
            public const string All = "Kalite";
        }
        public static class Dashboard
        {
            public const string All = "Dashboard";
        }
        public static class Role
        {
            public const string Goruntule = "Rol Görüntüle";
            public const string Kaydet = "Rol Kaydet";
            public const string Sil = "Rol Sil";
        }
        
        public static class Kullanici
        {
            public const string Goruntule = "Kullanıcı Görüntüle";
            public const string Kaydet = "Kullanıcı Kaydet";
            public const string Sil = "Kullanıcı Sil";
        }
        public static class KullaniciGrup
        {
            public const string All = "KullaniciGrup All";
        }
    
        public static class Log
        {
            public const string All = "LogAll";
        }
 
        public static List<string> getPermissions()
        {
            List<string> Permissions = new List<string>();

            foreach (Type type in typeof(Permissions).GetNestedTypes())
            {
                foreach (var fiels in type.GetFields())
                {
                    Permissions.Add(fiels.GetValue(type).ToString());
                };
            }

            return Permissions;
        }

   }
}
