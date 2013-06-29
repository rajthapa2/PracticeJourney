practice_journey.Sections = function (risk) {
    var self = this;
    self.PersonalDetailsSection = new practice_journey.Section(practice_journey.PersonalDetailsModel.SectionName, risk.PersonalDetails, 'Personal-details');
    self.PolicyDetailsSection = new practice_journey.Section(practice_journey.PolicyDetailsModel.SectionName, risk.PolicyDetails, 'Policy-details');
    
};
