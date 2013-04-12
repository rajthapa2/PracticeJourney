practice_journey.PersonalDetailsModel = function (id, typeOfPerson) {
    var self = this;
    self.Id = id;
    self.TitleCode = ko.observable("").extend({ required: { message: practice_journey.ErrorMessage.required } });
}