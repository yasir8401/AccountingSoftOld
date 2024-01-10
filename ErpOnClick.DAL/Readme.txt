===================================
Scaffold Command 
===================================
Scaffold-DbContext "Server=DESKTOP-PF56OQF;Database=DB_A29478_nsDB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -context ERPonClickContext -force 




Documents
        [NotMapped]
        public IFormFile FileToUpload { get; set; }



EmpContractsPackage
          [NotMapped]
        public string IsDeleted { get; set; }


Applications
        [NotMapped] 
        public IFormFile CVFile { get; set; }
        [NotMapped]
        public IFormFile CoverLetterFile { get; set; }
