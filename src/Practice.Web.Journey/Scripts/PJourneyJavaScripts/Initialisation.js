﻿$(function () {
    var pages = new practice_journey.Pages();
    var journey = new practice_journey.JourneyModel(pages);
    journey.Init(pages[0], practice_journey.PersonalDetailsModel.SectionName);
    ko.applyBindings(new practice_journey.PersonalDetailsModel, document.getElementById("personal-details"));
});