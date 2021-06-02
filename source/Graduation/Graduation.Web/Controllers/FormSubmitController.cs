using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Graduation.Core;
using Graduation.Web.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Newtonsoft.Json;

namespace Graduation.Web.Controllers
{
    [ApiController]
    public class FormSubmitController
    {
        private readonly EducationContext _context;
        private readonly IPostalCodeProviderService _postalCodeProviderService;
        
        public FormSubmitController(EducationContext context, IPostalCodeProviderService postalCodeProviderService)
        {
            this._context = context;
            this._postalCodeProviderService = postalCodeProviderService;
        }
        
        [Route("Form")]
        [HttpPost]
        public async Task<bool> Submit([FromBody]FormSubmitRequest request, CancellationToken cancellationToken)
        {
            var clone = JsonConvert.DeserializeObject<FormSubmitRequest>(JsonConvert.SerializeObject(request));

            if (clone == null)
            {
                throw new ArgumentNullException(nameof(clone));
            }

            QualificationType qualificationType;  
            if (clone.QualificationType != "other")
            {
                clone.QualificationTypeText = string.Empty;
            }
            else
            {
                qualificationType = await this._context.QualificationTypes.FirstOrDefaultAsync(x =>
                    x.QualificationTypeLocalizations.Any(l => l.Name == clone.QualificationType) ||
                    x.DefaultName == clone.QualificationType);
            }

            if (clone.TeacherSpeech == false)
            {
                clone.TeacherSpeechText = string.Empty;
            }
            
            if (clone.TeacherWriting == false)
            {
                clone.TeacherWritingText = string.Empty;
            }
            
            if (clone.TeacherScreen == false)
            {
                clone.TeacherScreenText = string.Empty;
            }
            
            if (clone.StudentNotes == false)
            {
                clone.StudentNotesText = string.Empty;
            }
            
            if (clone.StudentQuestions == false)
            {
                clone.StudentQuestionsText = string.Empty;
            }

            if (clone.StudyProcess == false)
            {
                clone.StudyProcessText = string.Empty;
            }

            if (clone.LabParticipation == false)
            {
                clone.LabParticipationText = string.Empty;
            }

            if (clone.PcUsage == false)
            {
                clone.PcUsageText = string.Empty;
            }

            if (clone.Keyboard == false)
            {
                clone.KeyboardText = string.Empty;
            }

            if (clone.Mouse == false)
            {
                clone.MouseText = string.Empty;
            }

            if (clone.Screen == false)
            {
                clone.ScreenText = string.Empty;
            }

            if (clone.Speakers == false)
            {
                clone.SpeakersText = string.Empty;
            }

            this._context.FormSubmissions.Add(new FormSubmission
            {
                Data = JsonConvert.SerializeObject(clone)
            });

            await using (var transaction = await this._context.Database.BeginTransactionAsync(IsolationLevel.ReadCommitted, cancellationToken))
            {
                await this._context.SaveChangesAsync(cancellationToken);

                await transaction.CommitAsync(cancellationToken);
            }
            
            return true;
        }
    }
}