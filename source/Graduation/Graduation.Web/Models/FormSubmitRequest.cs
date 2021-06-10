using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using FluentValidation;

namespace Graduation.Web.Models
{
    public class FormSubmitRequest
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Surname")]
        public string Surname { get; set; }

        [JsonPropertyName("FathersName")]
        public string FathersName { get; set; }

        [JsonPropertyName("Gender")]
        public string Gender { get; set; }

        [JsonPropertyName("Department")]
        public string Department { get; set; }

        [JsonPropertyName("StudentId")]
        public string StudentId { get; set; }

        [JsonPropertyName("Disability")]
        public string Disability { get; set; }

        [JsonPropertyName("Phone")]
        public string Phone { get; set; }

        [JsonPropertyName("Mobile")]
        public string Mobile { get; set; }

        [JsonPropertyName("Email")]
        public string Email { get; set; }

        [JsonPropertyName("Address")]
        public string Address { get; set; }

        [JsonPropertyName("PostalCode")]
        public string PostalCode { get; set; }

        [JsonPropertyName("QualificationType")]
        public string QualificationType { get; set; }

        [JsonPropertyName("QualificationTypeText")]
        public string QualificationTypeText { get; set; }

        [JsonPropertyName("QualificationYear")]
        public int QualificationYear { get; set; }

        [JsonPropertyName("Vision")]
        public string Vision { get; set; }

        [JsonPropertyName("Hearing")]
        public string Hearing { get; set; }

        [JsonPropertyName("Speech")]
        public string Speech { get; set; }

        [JsonPropertyName("Stretching")]
        public string Stretching { get; set; }

        [JsonPropertyName("Dexterity")]
        public string Dexterity { get; set; }

        [JsonPropertyName("Movement")]
        public string Movement { get; set; }

        [JsonPropertyName("Understanding")]
        public string Understanding { get; set; }

        [JsonPropertyName("DisabilityAppearanceYear")]
        public int DisabilityAppearanceYear { get; set; }

        [JsonPropertyName("Library")]
        public bool Library { get; set; }

        [JsonPropertyName("Wc")]
        public bool Wc { get; set; }

        [JsonPropertyName("Elevator")]
        public bool Elevator { get; set; }

        [JsonPropertyName("Classroom")]
        public bool Classroom { get; set; }

        [JsonPropertyName("Amphitheater")]
        public bool Amphitheater { get; set; }

        [JsonPropertyName("Laboratory")]
        public bool Laboratory { get; set; }

        [JsonPropertyName("Secretary")]
        public bool Secretary { get; set; }

        [JsonPropertyName("Canteen")]
        public bool Canteen { get; set; }

        [JsonPropertyName("Orientation")]
        public bool Orientation { get; set; }

        [JsonPropertyName("Hearingaid")]
        public bool Hearingaid { get; set; }

        [JsonPropertyName("Wheelchair")]
        public bool Wheelchair { get; set; }

        [JsonPropertyName("Speechcomposer")]
        public bool Speechcomposer { get; set; }

        [JsonPropertyName("Virtualkeyboard")]
        public bool Virtualkeyboard { get; set; }

        [JsonPropertyName("Wwitches")]
        public bool Wwitches { get; set; }

        [JsonPropertyName("Screenreader")]
        public bool Screenreader { get; set; }

        [JsonPropertyName("Braillescreen")]
        public bool Braillescreen { get; set; }

        [JsonPropertyName("PhsyicalAidOtherText")]
        public string PhsyicalAidOtherText { get; set; }

        [JsonPropertyName("DigitalAidOtherText")]
        public string DigitalAidOtherText { get; set; }

        [JsonPropertyName("Keyboard")]
        public bool Keyboard { get; set; }

        [JsonPropertyName("KeyboardText")]
        public string KeyboardText { get; set; }

        [JsonPropertyName("Mouse")]
        public bool Mouse { get; set; }

        [JsonPropertyName("MouseText")]
        public string MouseText { get; set; }

        [JsonPropertyName("Screen")]
        public bool Screen { get; set; }

        [JsonPropertyName("ScreenText")]
        public string ScreenText { get; set; }

        [JsonPropertyName("Speakers")]
        public bool Speakers { get; set; }

        [JsonPropertyName("SpeakersText")]
        public string SpeakersText { get; set; }

        [JsonPropertyName("TeacherSpeech")]
        public bool TeacherSpeech { get; set; }

        [JsonPropertyName("TeacherSpeechText")]
        public string TeacherSpeechText { get; set; }

        [JsonPropertyName("TeacherWriting")]
        public bool TeacherWriting { get; set; }

        [JsonPropertyName("TeacherWritingText")]
        public string TeacherWritingText { get; set; }

        [JsonPropertyName("TeacherScreen")]
        public bool TeacherScreen { get; set; }

        [JsonPropertyName("TeacherScreenText")]
        public string TeacherScreenText { get; set; }

        [JsonPropertyName("StudentNotes")]
        public bool StudentNotes { get; set; }

        [JsonPropertyName("StudentNotesText")]
        public string StudentNotesText { get; set; }

        [JsonPropertyName("StudentQuestions")]
        public bool StudentQuestions { get; set; }

        [JsonPropertyName("StudentQuestionsText")]
        public string StudentQuestionsText { get; set; }

        [JsonPropertyName("LearningDifficultyOtherText")]
        public string LearningDifficultyOtherText { get; set; }

        [JsonPropertyName("HelpOptions")]
        public bool HelpOptions { get; set; }

        [JsonPropertyName("HelpOptionsText")]
        public string HelpOptionsText { get; set; }

        [JsonPropertyName("StudyProcess")]
        public bool StudyProcess { get; set; }

        [JsonPropertyName("StudyProcessText")]
        public string StudyProcessText { get; set; }

        [JsonPropertyName("LabParticipation")]
        public bool LabParticipation { get; set; }

        [JsonPropertyName("LabParticipationText")]
        public string LabParticipationText { get; set; }

        [JsonPropertyName("PcUsage")]
        public bool PcUsage { get; set; }

        [JsonPropertyName("PcUsageText")]
        public string PcUsageText { get; set; }

        [JsonPropertyName("OralExams")]
        public bool OralExams { get; set; }

        [JsonPropertyName("DifferentQuestions")]
        public bool DifferentQuestions { get; set; }

        [JsonPropertyName("Braille")]
        public bool Braille { get; set; }

        [JsonPropertyName("Computer")]
        public bool Computer { get; set; }

        [JsonPropertyName("ExamsAidOtherText")]
        public string ExamsAidOtherText { get; set; }

        [JsonPropertyName("PassedCourses")]
        public int PassedCourses { get; set; }

        [JsonPropertyName("Courses")]
        public int Courses { get; set; }

        [JsonPropertyName("LastExamParticipationYear")]
        public int LastExamParticipationYear { get; set; }

        [JsonPropertyName("ParticipationDifficulty")]
        public string ParticipationDifficulty { get; set; }

        [JsonPropertyName("Suggestions")]
        public string Suggestions { get; set; }
    }

    public static class IRuleBuilderExtensions
    {
        public static IRuleBuilder<T, string> InLikertScale<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Custom((x, context) =>
                {
                    if (!int.TryParse(x, out var num) || num > 5 || num < 0)
                    {
                        context.AddFailure("Must be inside likert scale range [0,4]");
                    }
                });
        }
    }
}