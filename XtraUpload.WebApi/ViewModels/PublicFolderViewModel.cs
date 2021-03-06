﻿using System.ComponentModel.DataAnnotations;

namespace XtraUpload.WebApi
{
    public class PublicFolderViewModel
    {
        [Required]
        [RegularExpression("^[a-zA-Z0-9]*$")]
        public string MainFolderId { get; set; }

        [RegularExpression("^[a-zA-Z0-9]*$")]
        public string ChildFolderId { get; set; }
    }
}
