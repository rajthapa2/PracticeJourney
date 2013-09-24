practice_journey.SectionViewModel = function () {
    this.SaveActionUrl = "";
    this.Save = function (successCallback) {
        if (this.Validate()) {
            var serviceClient = new practice_journey.ServiceClient();
            serviceClient.post(this.SaveActionUrl, this.ToJSON(), successCallback);
        } else {
            this.showErrors();
            //practice_journey.showGenericError(this.Errors());
        }
    };
};