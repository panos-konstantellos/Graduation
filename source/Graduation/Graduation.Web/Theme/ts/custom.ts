import $ from "jquery";
import _ from "lodash";
import 'owl.carousel';

enum Gender
{
    Male,
    Female
}

interface FormModel
{
    Name: string,
    Surname: string,
    FathersName: string,
    Gender: Gender,
    Department: string,
    StudentId: string,
    Disability: string,
    Phone: string,
    Mobile: string,
    Email: string,
    Address: string,
    PostalCode: string,
    QualificationType: string,
    QualificationTypeText: string,
    QualificationYear: number,

    Vision: string,
    Hearing: string,
    Speech: string,
    Stretching: string,
    Dexterity: string,
    Movement: string,
    Understanding: string,
    DisabilityAppearanceYear: 0,

    Library: boolean,
    Wc: boolean,
    Elevator: boolean,
    Classroom: boolean,
    Amphitheater: boolean,
    Laboratory: boolean,
    Secretary: boolean,
    Canteen: boolean,
    Orientation: boolean,

    Hearingaid: boolean,
    Wheelchair: boolean,
    Speechcomposer: boolean,
    Virtualkeyboard: boolean,
    Wwitches: boolean,
    Screenreader: boolean,
    Braillescreen: boolean,
    PhsyicalAidOtherText: string,
    DigitalAidOtherText: string,

    Keyboard: boolean,
    KeyboardText: string,
    Mouse: boolean,
    MouseText: string,
    Screen: boolean,
    ScreenText: string,
    Speakers: boolean,
    SpeakersText: string,

    TeacherSpeech: boolean,
    TeacherSpeechText: string,
    TeacherWriting: boolean,
    TeacherWritingText: string,
    TeacherScreen: boolean,
    TeacherScreenText: string,
    StudentNotes: boolean,
    StudentNotesText: string,
    StudentQuestions: boolean,
    StudentQuestionsText: string,
    LearningDifficultyOtherText: string,

    HelpOptions : boolean,
    HelpOptionsText: string,

    StudyProcess: boolean,
    StudyProcessText: string,

    LabParticipation: boolean,
    LabParticipationText: string,

    PcUsage: boolean,
    PcUsageText: string,

    OralExams: boolean,
    DifferentQuestions: boolean,
    Braille: boolean,
    Computer: boolean,
    ExamsAidOtherText: string,

    PassedCourses: number,
    Courses: number,
    LastExamParticipationYear: number,

    ParticipationDifficulty: number,
    Suggestions: string
}

const isCheckbox = function (element: HTMLInputElement): boolean
{
    return element instanceof HTMLInputElement && element.type === 'checkbox';
}

const isRadio = function (element: HTMLInputElement): boolean
{
    return element instanceof HTMLInputElement && element.type === 'radio';
}

const isNumber = function (element: HTMLInputElement): boolean
{
    return element instanceof HTMLInputElement && element.type === 'number';
}

const isText = function (element: HTMLInputElement): boolean
{
    return element instanceof HTMLInputElement && element.type === 'text';
}

class FormStore
{
    private static readonly key:string = 'form';
    
    public Get(): FormModel
    {
        let _form = window.sessionStorage.getItem(FormStore.key);
        
        return JSON.parse(_form);
    }
    
    public Set(model: FormModel): void
    {
        let _form = JSON.stringify(model);
        
        window.sessionStorage.setItem(FormStore.key, _form);
    }
    
    public Reset(): void
    {
        window.sessionStorage.removeItem(FormStore.key);
    }
}

(function () {

    $('.form-select.postalcode').on('change', function() {

        var option = $(':selected', this);

        $('.form-select.area').val(option.data('area'));
        $('.form-select.prefecture').val(option.data('prefecture'));

    });

})();

(function () {
    'use strict'

    const forms = document.querySelectorAll('.needs-validation') as any;

    _.each(forms, form => 
    {
        form.addEventListener('submit', (event) =>
        {
            if (!form.checkValidity())
            {
                event.preventDefault();
                event.stopPropagation();

                $('form.needs-validation :invalid')[0].scrollIntoView(true);
            }

            form.classList.add('was-validated');
            
        }, false);
    });
    
})();


(function () {
    'use strict'

    const elements = document.querySelectorAll('.needs-validation input, .needs-validation textarea, .needs-validation select');

    let store = new FormStore();

    let form = store.Get();

    let defaultForm:FormModel = {
        Name: '',
        Surname: '',
        FathersName: '',
        Gender: null,
        Department: '',
        StudentId: '',
        Disability: '',
        Phone: '',
        Mobile: '',
        Email: '',
        Address: '',
        PostalCode: '',
        QualificationType: '',
        QualificationTypeText: '',
        QualificationYear: 0,
        Vision: '',
        Hearing: '',
        Speech: '',
        Stretching: '',
        Dexterity: '',
        Movement: '',
        Understanding: '',
        DisabilityAppearanceYear: 0,

        Library: false,
        Wc: false,
        Elevator: false,
        Classroom: false,
        Amphitheater: false,
        Laboratory: false,
        Secretary: false,
        Canteen: false,
        Orientation: false,

        Hearingaid: false,
        Wheelchair: false,
        Speechcomposer: false,
        Virtualkeyboard: false,
        Wwitches: false,
        Screenreader: false,
        Braillescreen: false,
        PhsyicalAidOtherText: '',
        DigitalAidOtherText: '',
        
        Keyboard: false,
        KeyboardText: '',
        Mouse: false,
        MouseText: '',
        Screen: false,
        ScreenText: '',
        Speakers: false,
        SpeakersText: '',

        TeacherSpeech: false,
        TeacherSpeechText: '',
        TeacherWriting: false,
        TeacherWritingText: '',
        TeacherScreen: false,
        TeacherScreenText: '',
        StudentNotes: false,
        StudentNotesText: '',
        StudentQuestions: false,
        StudentQuestionsText: '',
        LearningDifficultyOtherText: '',

        HelpOptions : false,
        HelpOptionsText: '',

        StudyProcess: false,
        StudyProcessText: '',

        LabParticipation: false,
        LabParticipationText: '',

        PcUsage: false,
        PcUsageText: '',

        OralExams: false,
        DifferentQuestions: false,
        Braille: false,
        Computer: false,
        ExamsAidOtherText: '',

        PassedCourses: 0,
        Courses: 0,
        LastExamParticipationYear: null,
        
        ParticipationDifficulty : 0,
        Suggestions: ''
    };

    form = _.extend({}, defaultForm, form || {});
    
    store.Set(form);

    _.each(elements, element =>
    {
        let key = Object.keys(form).find(x => x.toLowerCase() === ((element as any).type === 'radio' ? (element as any).name.toLowerCase() : element.id.toLowerCase()));

        if(!key)
        {
            return;
        }

        let value = form[key];
        
        if(typeof value !== 'boolean' && !!!value)
        {
            return;
        }
        
        switch (true)
        {
            case element instanceof HTMLSelectElement:
            case element instanceof HTMLInputElement:
            case element instanceof HTMLTextAreaElement:

                if(isCheckbox(element as HTMLInputElement)) 
                {
                    (element as any).checked = value;
                }
                else if(isRadio(element as HTMLInputElement))
                {
                    let elementId = `${(element as any).name}-${value.toString()}`;

                    (element as any).checked = element.id === elementId;
                }
                else
                {
                    (element as any).value = value.toString();
                }

                (element as any).dispatchEvent(new Event('change'));
                break;
            default:
                throw new Error('invalid element');
        }
    });
    
    _.each(elements, element =>
    {
        let updateValue = function (event)
        {
            element.classList.remove('is-valid', 'is-invalid');

            var isValid = (element as any).checkValidity();

            element.classList.add(isValid ? 'is-valid' : 'is-invalid');

            if (!isValid)
            {
                event.preventDefault();
                event.stopPropagation();
            }
            else
            {
                let key = Object.keys(form).find(x => x.toLowerCase() === ((element as any).type === 'radio' ? (element as any).name.toLowerCase() : element.id.toLowerCase()));
                if(!key)
                {
                    return;
                }

                let value;

                switch (true)
                {
                    case element instanceof HTMLSelectElement:
                    case element instanceof HTMLInputElement:
                    case element instanceof HTMLTextAreaElement:

                        if(isCheckbox(element as HTMLInputElement))
                        {
                            value = (element as any).checked;
                        }
                        else if(isRadio(element as HTMLInputElement))
                        {
                            let valueText = element.id.replace((element as any).name, '').replace('-', '');

                            if(valueText === 'true' || valueText === 'false')
                            {
                                value = valueText === 'true';
                            }
                            else
                            {
                                value = valueText;
                            }
                        }
                        else if(isNumber(element as HTMLInputElement))
                        {
                            value = Number((element as any).value);
                        }
                        else
                        {
                            value = (element as any).value;
                        }

                        break;
                    default:
                        throw new Error('invalid element');
                }

                form[key] = value;

                store.Set(form);

            }

        };

        element.addEventListener('change', updateValue, false);
        element.addEventListener('focusout', updateValue, false);
        element.addEventListener('keyup', updateValue, false);
        element.addEventListener('input', updateValue, false);
    });
})();

(function() {

    const applyRules = function (element: HTMLSelectElement | HTMLInputElement): boolean
    {
        if(element instanceof HTMLSelectElement)
        {
            return true;
        }
        
        if(element instanceof HTMLInputElement)
        {
            if(isCheckbox(element))
            {
                return true;
            }
            
            if(isRadio(element))
            {
                if(!element.checked)
                {
                    return false;
                }

                let valueText = element.id.replace(element.name, '').replace('-', '');
                if(!(valueText === 'true' || valueText === 'false'))
                {
                    return false;
                }
                
                return true;
            }
        }        
        
        throw new Error('Argument out of range exception');
    }
    
    const getCssClass = function (element: HTMLSelectElement | HTMLInputElement): string 
    {

        if(element instanceof HTMLSelectElement)
        {
            return $(element).val() === 'other' ? '' : 'd-none';
        }
        
        if(element instanceof HTMLInputElement)
        {
            if(isCheckbox(element))
            {
                return element.checked ? '' : 'd-none';
            }

            if(isRadio(element))
            {
                let valueText = element.id.replace(element.name, '').replace('-', '');

                return  element.checked && valueText === 'true' ? '' : 'd-none';
            }
        }
        
        throw new Error('Argument out of range exception');
        
    };
    
    const applyOtherElement = function (element: HTMLSelectElement | HTMLInputElement)
    {

        let otherElement = document.querySelector(`#${$(element).data('form-select-other-textby')}`);
        
        if(!!!otherElement)
        {
            return;
        }
        
        let otherElementWrapper = otherElement.closest('.input-group');

        if(!!!otherElementWrapper)
        {
            return;
        }
        
        if(!applyRules(element))
        {
            return;
        }
        
        let _class = getCssClass(element);

        otherElementWrapper.classList.remove('d-none');
        if(otherElement.hasAttribute('hidden-required'))
        {
            otherElement.removeAttribute('hidden-required');
            otherElement.setAttribute('required', '');
        }

        if(!!_class)
        {
            if(otherElement.hasAttribute('required'))
            {
                otherElement.removeAttribute('required');
                otherElement.setAttribute('hidden-required', '');
            }

            otherElementWrapper.classList.add(_class);
        }

    }

    const elements = (document.querySelectorAll('.needs-validation select, .needs-validation input[type=radio], .needs-validation input[type=checkbox]') as any) as Array<HTMLSelectElement | HTMLInputElement>;

    _.each(elements, element => 
    {
        if(!$(element).data('form-select-other-textby'))
        {
            return;
        }

        applyOtherElement(element);
        
        element.addEventListener('change', (event) => { applyOtherElement(element); },false);
    });
    
    
})();

(window as any).Form = (function(form: any) {
    'use strict'

    form.submit = function ()
    {
        let store = new FormStore();
        
        let form = store.Get();

        return new Promise((resolve, reject) => 
        {
            $.ajax({
                type: "POST",
                data: JSON.stringify(form),
                url: `${(window as any).Form.baseUrl}form`,
                contentType: "application/json charset=utf-8",
                headers:
                {
                    Accept: "application/json charset=utf-8"
                },
                success: function (data) 
                {
                    store.Reset();
                    
                    resolve(data)
                },
                error: function (error) 
                {
                    reject(error)
                },
            });
            
        });
        
    };
    
    return form;
    
})((window as any).Form || {});

(function (){
    'use strict';

    let carouselWrap: any = $('.owl-carousel');
    
    carouselWrap.owlCarousel({
        items: 1,
        loop: true,
        autoplay: true,
        dots: false
    });
    
})();