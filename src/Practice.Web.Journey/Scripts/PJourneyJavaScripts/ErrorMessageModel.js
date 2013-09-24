practice_journey.ErrorMessageModel = function () {
    var self = this;
};

practice_journey.showErrors = function (errors) {
    var errorMessagesModel = getErrorMessagesModel();
    if (!errorMessagesModel) errorMessagesModel = practice_journey.JourneyErrorMessages;
    errorMessagesModel(errors);
    $.scrollToTop();
};

practice_journey.showGenericError = function(error) {
    practice_journey.showErrors(errors);
};