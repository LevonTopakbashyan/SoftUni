package DefiningClasses;

public class Student {

        static int studentCount;

        private String name;
        private int year;
        private String profession;
        private String university;
        private String emailAddress;
        private int phoneNumber;

        public static int getStudentCount() {
            return studentCount;
        }

        public String getName() {
            return name;
        }

        public int getYear() {
            return year;
        }

        public String getProfession() {
            return profession;
        }

        public String getUniversity() {
            return university;
        }

        public String getEmailAddress() {
            return emailAddress;
        }

        public int getPhoneNumber() {
            return phoneNumber;
        }

        public Student(String name) {
            this.name = name;
        }

        public Student(String name, int year) {
            this.name = name;
            this.year = year;
        }

        public Student(String name, int year, String profession,
                       String university, String emailAddress, int phoneNumber) {
            this.name = name;
            this.year = year;
            this.profession = profession;
            this.university = university;
            this.emailAddress = emailAddress;
            this.phoneNumber = phoneNumber;
        }

        public void getInfo() {
            System.out.println(getName() + getEmailAddress() + getProfession() + getUniversity() + getPhoneNumber());
        }
}
