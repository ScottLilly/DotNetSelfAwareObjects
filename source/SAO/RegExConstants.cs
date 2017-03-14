namespace SAO
{
    public static class RegExConstants
    {
        public const string CELL_PHONE_ESN_NUMBER = @"^([0-9a-fA-F]){8}$";
        public const string ISBN = @"^ISBN\s(?=[-0-9xX ]{13}$)(?:[0-9]+[- ]){3}[0-9]*[xX0-9]$";
        public const string TIME_24_HOUR = @"([0-1][0-9]|2[0-3]):[0-5][0-9]";

        public static class Computer
        {
            public const string EMAIL_ADDRESS =
                @"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$";

            public const string FILE_NAME =
                @"^(?!^(PRN|AUX|CLOCK\$|NUL|CON|COM\d|LPT\d|\..*)(\..+)?$)[^\x00-\x1f\\?*:\;|/]+$";

            public const string IP_ADDRESS = @"\b(([01]?\d?\d|2[0-4]\d|25[0-5])\.){3}([01]?\d?\d|2[0-4]\d|25[0-5])\b";
            public const string MAC_ADDRESS = @"^([0-9a-fA-F][0-9a-fA-F]:){5}([0-9a-fA-F][0-9a-fA-F])$";
            public const string URI = @"^([a-zA-Z0-9]([a-zA-Z0-9\-]{0,61}[a-zA-Z0-9])?\.)+[a-zA-Z]{2,6}$";
        }

        public static class CreditCard
        {
            public const string ANY_CARD_NUMBER =
                @"^((?:4\d{3})|(?:5[1-5]\d{2})|(?:6011)|(?:3[68]\d{2})|(?:30[012345]\d))[ -]?(\d{4})[ -]?(\d{4})[ -]?(\d{4}|3[4,7]\d{13})$";

            public const string AMERICAN_EXPRESS_NUMBER = @"^([34|37]{2})([0-9]{13})$";
            public const string DINERS_CLUB_CARD_NUMBER = @"^([30|36|38]{2})([0-9]{12})$";
            public const string DISCOVER_CARD_NUMBER = @"^([6011]{4})([0-9]{12})$";
            public const string MASTERCARD_CARD_NUMBER = @"^([51|52|53|54|55]{2})([0-9]{14})$";
            public const string VISA_CARD_NUMBER = @"^([4]{1})([0-9]{12,15})$";
        }

        public static class DeliveryService
        {
            public const string DHL_WAYBILL_NUMBER = @"";
            public const string FED_EX_WAYBILL_NUMBER = @"";
            public const string UPS_WAYBILL_NUMBER = @"";
        }

        public static class Medical
        {
            public const string ICD9_CODE = @"^\d{3,3}\.\d{0,2}$|^E\d{3,3}\.\d{0,2}$";
        }

        public static class CountrySpecific
        {
            public static class Argentina
            {
                public const string POSTAL_CODE = @"^([A-HJ-TP-Z]{1}\d{4}[A-Z]{3}|[a-z]{1}\d{4}[a-hj-tp-z]{3})$";
            }

            public static class Australia
            {
                public static class PhoneNumber
                {
                    public const string GENERAL =
                        @"(^1300\d{6}$)|(^1800|1900|1902\d{6}$)|(^0[2|3|7|8]{1}[0-9]{8}$)|(^13\d{4}$)|(^04\d{2,3}\d{6}$)";

                    public const string LAND_LINE = @"^\({0,1}0(2|3|7|8)\){0,1}(\ |-){0,1}[0-9]{4}(\ |-){0,1}[0-9]{4}$";
                    public const string MOBILE = @"^0(6[045679][0469]){1}(\-)?(1)?[^0\D]{1}\d{6}$";
                }
            }

            public static class Brazil
            {
                public const string CNPJ_NUMBER = @"\d{2}.?\d{3}.?\d{3}/?\d{4}-?\d{2}";
                public const string POSTAL_CODE = @"^\d{2}(\x2e)(\d{3})(-\d{3})?$";

                public static class PhoneNumber
                {
                    public const string GENERAL =
                        @"^([0-9]{2})?((\([0-9]{2})\)|[0-9]{2})?([0-9]{3}|[0-9]{4})(\-)?[0-9]{4}$";
                }
            }

            public static class Canada
            {
                public const string POSTAL_CODE = @"^([A-Za-z]\d[A-Za-z][-]?\d[A-Za-z]\d)";

                public const string POSTAL_CODE_QUEBEC =
                    @"^[a-zA-Z]{1}[0-9]{1}[a-zA-Z]{1}(\-| |){1}[0-9]{1}[a-zA-Z]{1}[0-9]{1}$";

                public const string SOCIAL_INSURANCE_NUMBER = @"^\d{3}\s?\d{3}\s?\d{3}$";
            }

            public static class Denmark
            {
                public const string POSTAL_CODE = @"^[D-d][K-k]-[1-9]{1}[0-9]{3}$";
            }

            public static class France
            {
                public static class PhoneNumber
                {
                    public const string GENERAL = @"^0[1-6]{1}(([0-9]{2}){4})|((\s[0-9]{2}){4})|((-[0-9]{2}){4})$";
                }
            }

            public static class Germany
            {
                public const string POSTAL_CODE =
                    @"\b((?:0[1-46-9]\d{3})|(?:[1-357-9]\d{4})|(?:[4][0-24-9]\d{3})|(?:[6][013-9]\d{3}))\b";
            }

            public static class India
            {
                public const string POSTAL_CODE = @"^\d{3}\s?\d{3}$";

                public const string VEHICLE_REGISTRATION_NUMBER =
                    @"^([A-Z|a-z]{2}\s{1}\d{2}\s{1}[A-Z|a-z]{1,2}\s{1}\d{1,4})?([A-Z|a-z]{3}\s{1}\d{1,4})?$";

                public static class PhoneNumber
                {
                    public const string GENERAL = @"^0{0,1}[1-9]{1}[0-9]{2}[\s]{0,1}[\-]{0,1}[\s]{0,1}[1-9]{1}[0-9]{6}$";
                }
            }

            public static class Israel
            {
                public static class PhoneNumber
                {
                    public const string GENERAL = @"^0[23489]{1}(\-)?[^0\D]{1}\d{6}$";
                    public const string MOBILE = @"^0(5[012345678]|6[47]){1}(\-)?[^0\D]{1}\d{5}$";
                }
            }

            public static class Italy
            {
                public const string POSTAL_CODE = @"^(V-|I-)?[0-9]{4}$";

                public static class PhoneNumber
                {
                    public const string GENERAL = @"^([0-9]*\-?\ ?\/?[0-9]*)$";

                    public const string MOBILE =
                        @"^([+]39)?((38[{8,9}|0])|(34[{7-9}|0])|(36[6|8|0])|(33[{3-9}|0])|(32[{8,9}]))([\d]{7})$";
                }
            }

            public static class Peru
            {
                public static class PhoneNumber
                {
                    public const string MOBILE = @"^([8-9])([1-9])(\d{2})(-?|\040?)(\d{4})$";
                }
            }

            public static class Mexico
            {
                public const string RFC_NUMBER =
                    @"^([A-Z|a-z|&amp;]{3}\d{2}((0[1-9]|1[012])(0[1-9]|1\d|2[0-8])|(0[13456789]|1[012])(29|30)|(0[13578]|1[02])31)|([02468][048]|[13579][26])0229)(\w{2})([A|a|0-9]{1})$|^([A-Z|a-z]{4}\d{2}((0[1-9]|1[012])(0[1-9]|1\d|2[0-8])|(0[13456789]|1[012])(29|30)|(0[13578]|1[02])31)|([02468][048]|[13579][26])0229)((\w{2})([A|a|0-9]{1})){0,3}$";
            }

            public static class Netherlands
            {
                public const string POSTAL_CODE = @"^[1-9]{1}[0-9]{3}\s?[A-Z]{2}$";
            }

            public static class NewZealand
            {
                public static class PhoneNumber
                {
                    public const string MOBILE = @"(^\([0]\d{2}\))(\d{6,7}$)";
                }
            }

            public static class Russia
            {
                public const string POSTAL_CODE = @"^[0-9]{6}";
            }

            public static class SouthAfrica
            {
                public static class PhoneNumber
                {
                    public const string MOBILE = @"(^0[78][2347][0-9]{7})";
                }
            }

            public static class Spain
            {
                public const string POSTAL_CODE = @"^([1-9]{2}|[0-9][1-9]|[1-9][0-9])[0-9]{3}$";

                public static class PhoneNumber
                {
                    public const string GENERAL = @"^[0-9]{2,3}-? ?[0-9]{6,7}$";
                }
            }

            public static class Sweden
            {
                public const string PERSONAL_IDENTIFICATION_NUMBER =
                    @"[1-2][0|9][0-9]{2}[0-1][0-9][0-3][0-9][-][0-9]{4}";

                public const string POSTAL_CODE = @"^[S-s]( |-)?[1-9]{1}[0-9]{2}( |-)?[0-9]{2}$";

                public static class PhoneNumber
                {
                    public const string GENERAL =
                        @"^(([+]\d{2}[ ][1-9]\d{0,2}[ ])|([0]\d{1,3}[-]))((\d{2}([ ]\d{2}){2})|(\d{3}([ ]\d{3})*([ ]\d{2})+))$";
                }
            }

            public static class UAE
            {
                public static class PhoneNumber
                {
                    public const string LAND_LINE = @"^0[234679]{1}[\s]{0,1}[\-]{0,1}[\s]{0,1}[1-9]{1}[0-9]{6}$";

                    public const string MOBILE =
                        @"^(\+97[\s]{0,1}[\-]{0,1}[\s]{0,1}1|0)50[\s]{0,1}[\-]{0,1}[\s]{0,1}[1-9]{1}[0-9]{6}$";
                }
            }

            public static class UK
            {
                public const string BANK_SORT_NUMBER = @"^[0-9]{2}[-][0-9]{2}[-][0-9]{2}$";

                public const string NATIONAL_INSURANCE_NUMBER =
                    @"^[A-CEGHJ-PR-TW-Z]{1}[A-CEGHJ-NPR-TW-Z]{1}[0-9]{6}[A-DFM]{0,1}$";

                public const string POSTAL_CODE = @"^[A-Z]{1,2}[1-9][0-9]?[A-Z]? [0-9][A-Z]{2,}|GIR 0AA$";

                public const string VEHICLE_REGISTRATION_NUMBER =
                    @"^([A-Z]{3}\s?(\d{3}|\d{2}|d{1})\s?[A-Z])|([A-Z]\s?(\d{3}|\d{2}|\d{1})\s?[A-Z]{3})|(([A-HK-PRSVWY][A-HJ-PR-Y])\s?([0][2-9]|[1-9][0-9])\s?[A-HJ-PR-Z]{3})$";

                public static class PhoneNumber
                {
                    public const string LAND_LINE =
                        @"(02\d\s?\d{4}\s?\d{4})|(01\d{2}\s?\d{3}\s?\d{4})|(01\d{3}\s?\d{5,6})|(01\d{4}\s?\d{4,5})";

                    public const string MOBILE = @"^07([\d]{3})[(\D\s)]?[\d]{3}[(\D\s)]?[\d]{3}$";
                }
            }

            public static class US
            {
                public const string AMATEUR_RADIO_CALL_SIGN = @"^[AaWaKkNn][a-zA-Z]?[0-9][a-zA-Z]{1,3}$";
                public const string POSTAL_CODE = @"^(\d{5}-\d{4}|\d{5})$";

                public const string SOCIAL_SECURITY_NUMBER =
                    @"^(?=((0[1-9]0)|([1-7][1-7]\d)|(00[1-9])|(0[1-9][1-9]))-(?=(([1-9]0)|(0[1-9])|([1-9][1-9]))-(?=((\d{3}[1-9])$|([1-9]\d{3})$|(\d[1-9]\d{2})$|(\d{2}[1-9]\d)$))))";

                public const string ZIP_CODE = POSTAL_CODE;

                public static class PhoneNumber
                {
                    public const string GENERAL = @"^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$";
                }
            }
        }
    }
}