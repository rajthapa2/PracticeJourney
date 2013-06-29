practice_journey.Pages = function (risk) {
    var sections = new practice_journey.Sections(risk);
    var aboutYouPage = new practice_journey.Page('personal-details-section','Personal Details', [sections.PersonalDetailsSection]);
    var policyPage = new practice_journey.Page('policy-details-section', 'Policy Details', [sections.PolicyDetailsSection]);
    return [aboutYouPage, policyPage];
};