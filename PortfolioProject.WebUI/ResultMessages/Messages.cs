namespace PortfolioProject.WebUI.ResultMessages
{
    public static class Messages
    {
        public static class Experience
        {
            public static string Add(string experienceTitle)
            {
                return $"{experienceTitle} başlıklı tecrübe başarıyla eklenmiştir.";
            }
            public static string Update(string experienceTitle)
            {
                return $"{experienceTitle} başlıklı tecrübe başarıyla güncellenmiştir.";
            }
            public static string Delete(string experienceTitle)
            {
                return $"{experienceTitle} başlıklı tecrübe başarıyla silinmiştir.";
            }
            public static string UndoDelete(string experienceTitle)
            {
                return $"{experienceTitle} başlıklı tecrübe başarıyla geri alınmıştır.";
            }
        }
        public static class Skill
        {
            public static string Add(string skillName)
            {
                return $"{skillName} başlıklı yetenek başarıyla eklenmiştir.";
            }
            public static string Update(string skillName)
            {
                return $"{skillName} başlıklı yetenek başarıyla güncellenmiştir.";
            }
            public static string Delete(string skillName)
            {
                return $"{skillName} başlıklı yetenek başarıyla silinmiştir.";
            }
            public static string UndoDelete(string skillName)
            {
                return $"{skillName} başlıklı yetenek başarıyla geri alınmıştır.";
            }
        }
        public static class Education
        {
            public static string Add(string educationName)
            {
                return $"{educationName} başlıklı eğitim bilgisi başarıyla eklenmiştir.";
            }
            public static string Update(string educationName)
            {
                return $"{educationName} başlıklı eğitim bilgisi başarıyla güncellenmiştir.";
            }
            public static string Delete(string educationName)
            {
                return $"{educationName} başlıklı eğitim bilgisi başarıyla silinmiştir.";
            }
            public static string UndoDelete(string educationName)
            {
                return $"{educationName} başlıklı eğitim bilgisi başarıyla geri alınmıştır.";
            }
        }
        public static class Portfolio
        {
            public static string Add(string portfolioName)
            {
                return $"{portfolioName} başlıklı portfolyo bilgisi başarıyla eklenmiştir.";
            }
            public static string Update(string portfolioName)
            {
                return $"{portfolioName} başlıklı portfolyo bilgisi başarıyla güncellenmiştir.";
            }
            public static string Delete(string portfolioName)
            {
                return $"{portfolioName} başlıklı portfolyo bilgisi başarıyla silinmiştir.";
            }
            public static string UndoDelete(string portfolioName)
            {
                return $"{portfolioName} başlıklı portfolyo bilgisi başarıyla geri alınmıştır.";
            }
        }
        public static class User
        {
            public static string Add(string userName)
            {
                return $"{userName} email adresli kullanıcı başarıyla eklenmiştir.";
            }
            public static string Update(string userName)
            {
                return $"{userName} email adresli kullanıcı başarıyla güncellenmiştir.";
            }
            public static string Delete(string userName)
            {
                return $"{userName} email adresli kullanıcı başarıyla silinmiştir.";
            }
        }
    }
}
