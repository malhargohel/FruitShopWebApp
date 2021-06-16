using System;
using System.ComponentModel.DataAnnotations;

namespace CURDOperationWithImageUploadCore5_Demo.ViewModels
{
    public class SpeakerViewModel : EditImageViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string SpeakerName { get; set; }



        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime SpeakingDate { get; set; }


    }
}