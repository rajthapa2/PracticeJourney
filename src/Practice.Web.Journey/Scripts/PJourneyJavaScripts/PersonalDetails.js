practice_journey.PersonalDetailsModel = function () {
    var self = this;
    //    self.Id = id;
    //    self.TypeOfPerson = typeOfPerson;

    practice_journey.SectionViewModel.apply(this, arguments);
    this.SaveActionUrl = 'risk/SavePersonalDetails';

    self.TitleCode = ko.observable("");
    //.extend({ required: { message: practice_journey.ErrorMessage.required} });
    self.FirstName = ko.observable("");
    //.extend({ required: { message: practice_journey.ErrorMessage.required} });
    self.LastName = ko.observable("");
    //.extend({ required: { message: practice_journey.ErrorMessage.required} });
    self.MaritalStatus = ko.observable("");
    //.extend({ required: { message: practice_journey.ErrorMessage.required} });
    self.FullName = ko.computed({
        read: function () {
            return self.FirstName() + " " + self.LastName()
        },
        write: function (value) {
            var lastSpacePos = value.lastIndexOf(" ");
            if (lastSpacePos > 0) {
                this.FirstName(value.substring(0, lastSpacePos));
                this.LastName(value.substring(lastSpacePos + 1));
            }
        }, owner: this
    });
};

practice_journey.PersonalDetailsModel.SectionName = 'personal-details-section';