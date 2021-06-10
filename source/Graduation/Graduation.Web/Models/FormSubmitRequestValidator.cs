using System;
using System.Linq;

using FluentValidation;

using Graduation.Core;

using Microsoft.EntityFrameworkCore;

namespace Graduation.Web.Models
{
    class FormSubmitRequestValidator : AbstractValidator<FormSubmitRequest>
    {
        public FormSubmitRequestValidator(EducationContext context)
        {
            var departments =  context.Departments.Select(x => x.Code).ToList();
            // step 1
            this.RuleFor(x => x.Name).NotNull().NotEmpty();
            this.RuleFor(x => x.Surname).NotNull().NotEmpty();
            this.RuleFor(x => x.FathersName).NotNull().NotEmpty();
            this.RuleFor(x => x.Department).NotNull().NotEmpty();
            this.RuleFor(x => x.Department).Custom((x, context) =>
            {
                if (!departments.Contains(x))
                {
                    context.AddFailure($@"Invalid department {x}");
                }
            });
            this.RuleFor(x => x.Disability).NotNull().NotEmpty();
            this.RuleFor(x => x.Email).NotNull().NotEmpty().EmailAddress(); // TODO: add regex validation
            this.RuleFor(x => x.Address).NotNull().NotEmpty();
            this.RuleFor(x => x.PostalCode).NotNull().NotEmpty();

            this.RuleFor(x => x.StudentId).NotNull().NotEmpty(); // TODO: add regex validation

            this.RuleFor(x => x.Phone).NotNull().NotEmpty(); // TODO: add regex validation
            this.RuleFor(x => x.Mobile).NotNull().NotEmpty(); // TODO: add regex validation
            
            // step 2
            this.RuleFor(x => x.QualificationType).NotNull().NotEmpty();
            this.RuleFor(x => x.QualificationTypeText).NotNull().NotEmpty()
                .When(x => x.QualificationType.Equals("other", StringComparison.OrdinalIgnoreCase));
            
            this.RuleFor(x => x.QualificationYear).GreaterThanOrEqualTo(1990).LessThanOrEqualTo(DateTime.UtcNow.Year);

            // step 3
            this.RuleFor(x => x.Vision).NotNull().NotEmpty().InLikertScale();
            this.RuleFor(x => x.Hearing).NotNull().NotEmpty().InLikertScale();
            this.RuleFor(x => x.Speech).NotNull().NotEmpty().InLikertScale();
            this.RuleFor(x => x.Stretching).NotNull().NotEmpty().InLikertScale();
            this.RuleFor(x => x.Dexterity).NotNull().NotEmpty().InLikertScale();
            this.RuleFor(x => x.Movement).NotNull().NotEmpty().InLikertScale();
            this.RuleFor(x => x.Understanding).NotNull().NotEmpty().InLikertScale();
            
            this.RuleFor(x => x.DisabilityAppearanceYear).GreaterThanOrEqualTo(1990).LessThanOrEqualTo(DateTime.UtcNow.Year);

            //step 4
            this.RuleFor(x => x.HelpOptionsText).NotNull().NotEmpty()
                .When(x => x.HelpOptions);

            this.RuleFor(x => x.TeacherSpeechText).NotNull().NotEmpty()
                .When(x => x.TeacherSpeech);
            this.RuleFor(x => x.TeacherWritingText).NotNull().NotEmpty()
                .When(x => x.TeacherWriting);
            this.RuleFor(x => x.TeacherScreenText).NotNull().NotEmpty()
                .When(x => x.TeacherScreen);
            this.RuleFor(x => x.StudentNotesText).NotNull().NotEmpty()
                .When(x => x.StudentNotes);
            this.RuleFor(x => x.StudentQuestionsText).NotNull().NotEmpty()
                .When(x => x.StudentQuestions);
            
            this.RuleFor(x => x.StudyProcessText).NotNull().NotEmpty()
                .When(x => x.StudyProcess);
            this.RuleFor(x => x.LabParticipationText).NotNull().NotEmpty()
                .When(x => x.LabParticipation);
            this.RuleFor(x => x.PcUsageText).NotNull().NotEmpty()
                .When(x => x.PcUsage);
            
            this.RuleFor(x => x.MouseText).NotNull().NotEmpty()
                .When(x => x.Mouse);
            this.RuleFor(x => x.KeyboardText).NotNull().NotEmpty()
                .When(x => x.Keyboard);
            this.RuleFor(x => x.ScreenText).NotNull().NotEmpty()
                .When(x => x.Screen);
            this.RuleFor(x => x.SpeakersText).NotNull().NotEmpty()
                .When(x => x.Speakers);
            
            //step 5
            this.RuleFor(x => x.Courses).GreaterThan(0);
            this.RuleFor(x => x.PassedCourses).GreaterThanOrEqualTo(0);
            this.RuleFor(x => x.LastExamParticipationYear).GreaterThanOrEqualTo(1990).LessThanOrEqualTo(DateTime.UtcNow.Year);

            this.RuleFor(x => x.ParticipationDifficulty).NotNull().NotEmpty().InLikertScale();
        }
    }
}