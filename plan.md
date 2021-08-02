## Doctor's office
office admins
- track patients in a doctor's office
- will have doctor's office db with tables for doctor, patient, etc

Functionality for admin
- add doctor to the system
  - 2 columns
    - name
    - specialty
- add patient to a doctor
  - name
  - birthdate
    - Doctor - its own class
    - Patient - its own class
      - relationship between Doctor object and Patient object
- add more than one doctor to a patient

Doctor's office grwon to include many doctors with same specialty
- organized themselves into specialty groups
- when user wants to enter a doctor, must first select specialty and then add doctor from there

Functionality
- list all of the doctors in a particular specialty
  - doctor can have MANY specialties
  - hint: change database from storing `specialty` as column to giving its own table with a relationship to a `Doctor` object
- view a chart of doctors including number of patients the see
  - use SQL `COUNT` function
  - practice online search skills to figure out how it works