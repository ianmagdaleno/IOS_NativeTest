using System;
using UnityEngine;

using SA.iOS.Foundation.Internal;

namespace SA.iOS.Foundation
{
    /// <summary>
    /// Information about linguistic, cultural, and technological conventions 
    /// for use in formatting data for presentation.
    /// </summary>
    [Serializable]
    public class ISN_NSLocale 
    {
        [SerializeField] string m_identifier = string.Empty;
        [SerializeField] string m_countryCode = "US";
        [SerializeField] string m_languageCode = "US";
        [SerializeField] string m_currencySymbol = "$";
        [SerializeField] string m_currencyCode = "USD";

        /// <summary>
        /// A locale representing the user's region settings at the time the property is read.
        /// 
        /// The locale is formed from the settings for the current user’s chosen system locale 
        /// overlaid with any custom settings the user has specified.
        /// 
        /// Use this property when you need to rely on a consistent locale. 
        /// A locale instance obtained this way does not change even when the user changes region settings.
        /// If you want a locale instance that always reflects the current configuration, 
        /// use the one provided by the <see cref="AutoUpdatingCurrentLocale"/> property instead.
        /// </summary>
        /// <value>The current locale.</value>
        public static ISN_NSLocale CurrentLocale {
            get {
                return ISN_NSLib.API.CurrentLocale;
            }
        }

        /// <summary>
        /// A locale representing the user's region settings at the time the property is read.
        /// 
        /// The locale is formed from the settings for the current user’s chosen system locale 
        /// overlaid with any custom settings the user has specified.
        /// 
        /// Use this property when you want a locale that always reflects the latest configuration settings. 
        /// When the user changes settings, a locale instance obtained from this property alters its behavior to match. 
        /// If you need to rely on a locale that does not change, 
        /// use the locale given by the <see cref="CurrentLocale"/> property instead.
        /// </summary>
        /// <value>The current locale.</value>
        public static ISN_NSLocale AutoUpdatingCurrentLocale 
        {
            get {
                return ISN_NSLib.API.AutoUpdatingCurrentLocale;
            }
        }
        
        /// <summary>
        /// Users choose a primary language when configuring a device, as described in
        /// <see href="https://developer.apple.com/library/archive/documentation/MacOSX/Conceptual/BPInternational/SpecifyingPreferences/SpecifyingPreferences.html#//apple_ref/doc/uid/10000171i-CH12">Reviewing Language and Region Settings.</see>
        /// They may also specify one or more secondary languages in order of preference for use
        /// when localization is unavailable in a higher priority language.
        /// Use this property to obtain the current user's  language.
        ///  For more information about language localization in your app, see
        /// <see href="https://developer.apple.com/library/archive/documentation/MacOSX/Conceptual/BPInternational/LanguageandLocaleIDs/LanguageandLocaleIDs.html#//apple_ref/doc/uid/10000171i-CH15"/> Language and Locale IDs.</see>
        /// </summary>
        public static string PreferredLanguage
        {
            get
            {
                return ISN_NSLib.API.PreferredLanguage; 
            }
        }

        /// <summary>
        /// The identifier for the locale.
        /// </summary>
        public string Identifier 
        {
            get 
            {
                return m_identifier;
            }
        }


        /// <summary>
        /// The country code for the locale.
        /// Examples of country codes include "GB", "FR", and "HK".
        /// </summary>
        public string CountryCode 
        {
            get 
            {
                return m_countryCode;
            }
        }

        /// <summary>
        /// The language code for the locale.
        /// Examples of language codes include "en", "es", and "zh".
        /// </summary>
        public string LanguageCode 
        {
            get 
            {
                return m_languageCode;
            }
        }

        /// <summary>
        /// The currency symbol for the locale.
        /// Example currency symbols include "$", "€", and "¥".
        /// </summary>
        public string CurrencySymbol 
        {
            get 
            {
                return m_currencySymbol;
            }
        }


        /// <summary>
        /// The currency code for the locale.
        /// Example currency codes include "USD", "EUR", and "JPY".
        /// </summary>
        public string CurrencyCode 
        {
            get 
            {
                return m_currencyCode;
            }
        }
    }
}