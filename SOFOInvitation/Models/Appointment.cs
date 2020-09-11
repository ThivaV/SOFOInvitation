using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOFOInvitation.Models
{
    public class Appointment
    {
        public Associate Associate { get; set; }
        public Contact Contact { get; set; }
        public CreatedBy CreatedBy { get; set; }
        public UpdatedBy UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int AppointmentId { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public InvitedPerson InvitedPerson { get; set; }
        public Person Person { get; set; }
        public int MotherId { get; set; }
        public Priority Priority { get; set; }
        public string Private { get; set; }
        public Project Project { get; set; }
        public string Type { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Completed { get; set; }
        public int ActiveLinks { get; set; }
        public List<Link> Links { get; set; }
        public string AlarmLeadTime { get; set; }
        public bool HasAlarm { get; set; }
        public int ColorIndex { get; set; }
        public bool IsFree { get; set; }
        public bool IsAlldayEvent { get; set; }
        public string LagTime { get; set; }
        public string LeadTime { get; set; }
        public string Location { get; set; }
        public int RejectCounter { get; set; }
        public string RejectReason { get; set; }
        public Recurrence Recurrence { get; set; }
        public List<Participant> Participants { get; set; }
        public string AssignmentStatus { get; set; }
        public string InvitationStatus { get; set; }
        public string BookingType { get; set; }
        public DateTime ActiveDate { get; set; }
        public bool HasConflict { get; set; }
        public AssignedBy AssignedBy { get; set; }
        public MotherAssociate MotherAssociate { get; set; }
        public Task Task { get; set; }
        public int PreferredTZLocation { get; set; }
        public Sale Sale { get; set; }
        public int SuggestedAppointmentId { get; set; }
        public bool IsMileStone { get; set; }
        public string CautionWarning { get; set; }
        public string JoinVideomeetUrl { get; set; }
        public string CentralserviceVideomeetId { get; set; }
        public UserDefinedFields UserDefinedFields { get; set; }
        public ExtraFields ExtraFields { get; set; }
        public CustomFields CustomFields { get; set; }
        public DateTime PublishEventDate { get; set; }
        public DateTime PublishTo { get; set; }
        public DateTime PublishFrom { get; set; }
        public bool IsPublished { get; set; }
        public List<VisibleFor> VisibleFor { get; set; }
    }

    public class Associate
    {
        public int AssociateId { get; set; }
        public string Name { get; set; }
        public int PersonId { get; set; }
        public int Rank { get; set; }
        public string Tooltip { get; set; }
        public string Type { get; set; }
        public int GroupIdx { get; set; }
        public string FullName { get; set; }
        public string FormalName { get; set; }
        public bool Deleted { get; set; }
        public int EjUserId { get; set; }
        public string UserName { get; set; }
    }

    public class Address
    {
    }
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string OrgNr { get; set; }
        public string Department { get; set; }
        public string URL { get; set; }
        public string City { get; set; }
        public string DirectPhone { get; set; }
        public int AssociateId { get; set; }
        public int CountryId { get; set; }
        public string EmailAddress { get; set; }
        public string Kananame { get; set; }
        public string EmailAddressName { get; set; }
        public string URLName { get; set; }
        public string AssociateFullName { get; set; }
        public string BusinessName { get; set; }
        public string CategoryName { get; set; }
        public string CountryName { get; set; }
        public Address Address { get; set; }
        public string FormattedAddress { get; set; }
        public string FullName { get; set; }
        public bool IsOwnerContact { get; set; }
        public int ActiveErpLinks { get; set; }
    }
    
    public class CreatedBy
    {
        public int AssociateId { get; set; }
        public string Name { get; set; }
        public int PersonId { get; set; }
        public int Rank { get; set; }
        public string Tooltip { get; set; }
        public string Type { get; set; }
        public int GroupIdx { get; set; }
        public string FullName { get; set; }
        public string FormalName { get; set; }
        public bool Deleted { get; set; }
        public int EjUserId { get; set; }
        public string UserName { get; set; }
    }
    
    public class UpdatedBy
    {
        public int AssociateId { get; set; }
        public string Name { get; set; }
        public int PersonId { get; set; }
        public int Rank { get; set; }
        public string Tooltip { get; set; }
        public string Type { get; set; }
        public int GroupIdx { get; set; }
        public string FullName { get; set; }
        public string FormalName { get; set; }
        public bool Deleted { get; set; }
        public int EjUserId { get; set; }
        public string UserName { get; set; }
    }

    public class InvitedPerson
    {
        public string Position { get; set; }
        public int PersonId { get; set; }
        public string Mrmrs { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string MiddleName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string DirectPhone { get; set; }
        public string FormalName { get; set; }
        public int CountryId { get; set; }
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public int Retired { get; set; }
        public int Rank { get; set; }
        public int ActiveInterests { get; set; }
        public string ContactDepartment { get; set; }
        public int ContactCountryId { get; set; }
        public string ContactOrgNr { get; set; }
        public string FaxPhone { get; set; }
        public string MobilePhone { get; set; }
        public string ContactPhone { get; set; }
        public string AssociateName { get; set; }
        public int AssociateId { get; set; }
        public bool UsePersonAddress { get; set; }
        public string ContactFax { get; set; }
        public string Kanafname { get; set; }
        public string Kanalname { get; set; }
        public string Post1 { get; set; }
        public string Post2 { get; set; }
        public string Post3 { get; set; }
        public string EmailName { get; set; }
        public string ContactFullName { get; set; }
        public int ActiveErpLinks { get; set; }
        public int TicketPriorityId { get; set; }
        public int SupportLanguageId { get; set; }
        public int SupportAssociateId { get; set; }
        public string CategoryName { get; set; }
    }
    
    public class Person
    {
        public string Position { get; set; }
        public int PersonId { get; set; }
        public string Mrmrs { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string MiddleName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string DirectPhone { get; set; }
        public string FormalName { get; set; }
        public int CountryId { get; set; }
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public int Retired { get; set; }
        public int Rank { get; set; }
        public int ActiveInterests { get; set; }
        public string ContactDepartment { get; set; }
        public int ContactCountryId { get; set; }
        public string ContactOrgNr { get; set; }
        public string FaxPhone { get; set; }
        public string MobilePhone { get; set; }
        public string ContactPhone { get; set; }
        public string AssociateName { get; set; }
        public int AssociateId { get; set; }
        public bool UsePersonAddress { get; set; }
        public string ContactFax { get; set; }
        public string Kanafname { get; set; }
        public string Kanalname { get; set; }
        public string Post1 { get; set; }
        public string Post2 { get; set; }
        public string Post3 { get; set; }
        public string EmailName { get; set; }
        public string ContactFullName { get; set; }
        public int ActiveErpLinks { get; set; }
        public int TicketPriorityId { get; set; }
        public int SupportLanguageId { get; set; }
        public int SupportAssociateId { get; set; }
        public string CategoryName { get; set; }
    }

    public class Priority
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Tooltip { get; set; }
    }

    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public string Type { get; set; }
        public int AssociateId { get; set; }
        public string AssociateFullName { get; set; }
        public int TypeId { get; set; }
        public DateTime Updated { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public int TextId { get; set; }
        public DateTime PublishTo { get; set; }
        public DateTime PublishFrom { get; set; }
        public bool IsPublished { get; set; }
        public string URLName { get; set; }
        public string ProjectNumber { get; set; }
        public int ActiveErpLinks { get; set; }
    }

    public class Link
    {
        public string EntityName { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public string ExtraInfo { get; set; }
        public int LinkId { get; set; }
    }

    public class DayPattern
    {
    }

    public class WeekPattern
    {
    }

    public class MonthPattern
    {
    }

    public class YearPattern
    {
    }

    public class Date
    {
    }

    public class Recurrence
    {
        public int RecurrenceId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int RecurrenceCounter { get; set; }
        public string RecurrenceEndType { get; set; }
        public string Pattern { get; set; }
        public DayPattern DayPattern { get; set; }
        public WeekPattern WeekPattern { get; set; }
        public MonthPattern MonthPattern { get; set; }
        public YearPattern YearPattern { get; set; }
        public List<Date> Dates { get; set; }
        public bool IsRecurrence { get; set; }
    }
    public class Participant
    {
        public int AssociateId { get; set; }
        public int PersonId { get; set; }
        public int ContactId { get; set; }
        public int EmailId { get; set; }
        public bool SendEmail { get; set; }
        public string InvitationStatus { get; set; }
    }

    public class AssignedBy
    {
        public int AssociateId { get; set; }
        public string Name { get; set; }
        public int PersonId { get; set; }
        public int Rank { get; set; }
        public string Tooltip { get; set; }
        public string Type { get; set; }
        public int GroupIdx { get; set; }
        public string FullName { get; set; }
        public string FormalName { get; set; }
        public bool Deleted { get; set; }
        public int EjUserId { get; set; }
        public string UserName { get; set; }
    }

    public class MotherAssociate
    {
        public int AssociateId { get; set; }
        public string Name { get; set; }
        public int PersonId { get; set; }
        public int Rank { get; set; }
        public string Tooltip { get; set; }
        public string Type { get; set; }
        public int GroupIdx { get; set; }
        public string FullName { get; set; }
        public string FormalName { get; set; }
        public bool Deleted { get; set; }
        public int EjUserId { get; set; }
        public string UserName { get; set; }
    }

    public class Task
    {
        public int TaskListItemId { get; set; }
        public string Value { get; set; }
        public string Direction { get; set; }
        public string Type { get; set; }
        public string Tooltip { get; set; }
        public bool Deleted { get; set; }
        public int IntentId { get; set; }
        public int Rank { get; set; }
        public bool IsDefaultAlldayEvent { get; set; }
        public bool IsDefaultFree { get; set; }
        public bool IsDefaultPublished { get; set; }
        public string ColorIndex { get; set; }
        public string DefaultVideomeetingStatus { get; set; }
    }

    public class Sale
    {
        public string ContactName { get; set; }
        public DateTime SaleDate { get; set; }
        public int SaleId { get; set; }
        public int Probability { get; set; }
        public string Title { get; set; }
        public double Amount { get; set; }
        public string Currency { get; set; }
        public string ProjectName { get; set; }
        public string AssociateFullName { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public double WeightedAmount { get; set; }
        public int ProjectId { get; set; }
        public double EarningPercent { get; set; }
        public double Earning { get; set; }
        public int ContactId { get; set; }
        public int AssociateId { get; set; }
        public int PersonId { get; set; }
        public int SaleTypeId { get; set; }
        public string SaleTypeName { get; set; }
        public string PersonFullName { get; set; }
        public string Completed { get; set; }
        public int ActiveErpLinks { get; set; }
        public DateTime NextDueDate { get; set; }
    }

    public class UserDefinedFields { }

    public class ExtraFields {}

    public class CustomFields {}

    public class VisibleFor
    {
        public int VisibleId { get; set; }
        public string Visibility { get; set; }
        public string DisplayValue { get; set; }
    }
}
