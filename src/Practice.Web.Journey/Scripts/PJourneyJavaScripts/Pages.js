practice_journey.Pages = function () {
    var sections = new practice_journey.Sections();
    var aboutYouPage = new practice_journey.Page('aboutYouPage', 'About You', [sections.PersonalDetailsSection]);
    return [aboutYouPage];
};