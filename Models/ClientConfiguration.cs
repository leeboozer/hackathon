using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ClientConfiguration
    {
        public long ClientConfigurationId { get; set; }
        public long ClientId { get; set; }
        public string HitDelivery { get; set; }
        public string NonHitDelivery { get; set; }
        public Guid? MissingContact { get; set; }
        public string PreferredContact { get; set; }
        public int? ReminderFrequency { get; set; }
        public int? ReminderCount { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public bool ApiEnabled { get; set; }
        public string ApiCallbackBaseUrl { get; set; }
        public string ApiCallbackUserName { get; set; }
        public string ApiCallbackPassword { get; set; }
        public string ApiLogoPath { get; set; }
        public bool? ApiSendInvitation { get; set; }
        public bool? ApiMarkClearAsEligible { get; set; }
        public bool AdvEnabled { get; set; }
        public bool SharingCreditsDisabled { get; set; }
        public bool? PushExtrasToChildren { get; set; }
        public bool? RequireExtra1 { get; set; }
        public bool? DisplayExtra1 { get; set; }
        public bool? IsListExtra1 { get; set; }
        public string ListValuesExtra1 { get; set; }
        public bool? RequireExtra2 { get; set; }
        public bool? DisplayExtra2 { get; set; }
        public bool? IsListExtra2 { get; set; }
        public string ListValuesExtra2 { get; set; }
        public bool? RequireExtra3 { get; set; }
        public bool? DisplayExtra3 { get; set; }
        public bool? IsListExtra3 { get; set; }
        public string ListValuesExtra3 { get; set; }
        public string VolOrderTitle { get; set; }
        public string VolOrderInstructions { get; set; }
        public bool ResendAttachments { get; set; }
        public bool? AdvRatingRestrictionsEnabled { get; set; }
        public bool? ReusePreviousNeglectAbuseScreen { get; set; }
        public short? MaxBgAgeForInvitedShare { get; set; }
        public bool? ApiEnablePushNotifications { get; set; }
        public bool VolOrderViewsDisplay { get; set; }
        public string VolOrderViewsTitle { get; set; }
        public string VolOrderViewsInstruction { get; set; }

        public virtual Client Client { get; set; }
    }
}
