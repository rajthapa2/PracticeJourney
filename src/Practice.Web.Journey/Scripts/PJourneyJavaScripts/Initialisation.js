$(function () {

    var pages = new practice_journey.Pages();
    var journey = new practice_journey.JourneyModel(pages);
    journey.Init(pages[0], practice_journey.Sections[0]);

});