$(function () {

    //just a hack to fix retrievedRisk issue
    practice_journey.retrievedRisk = { PersonalDetails: '', PolicyDetails: '' };

    var risk = new practice_journey.Risk();
    var pages = new practice_journey.Pages(risk);
    var journey = new practice_journey.JourneyModel(pages,risk);
    journey.Init(pages[0], practice_journey.PersonalDetailsModel.SectionName);
    ko.applyBindings(new practice_journey.PersonalDetailsModel, document.getElementById("personal-details"));
});