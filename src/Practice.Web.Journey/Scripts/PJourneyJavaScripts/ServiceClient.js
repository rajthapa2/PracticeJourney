practice_journey.ServiceClient = function () {
    var self = this;
    self.defaultErrorcallback = function (response) {
        var errors = ["There was an unexpected error.In the mean time please try again"];
        if (response.status === 400 || response.status === 404 || response.status === 500) {
            try {
                errors = JSON.parse(response.responseText)
            } catch (e) {
            }
        } else {
            if (response.status === 412) {
                if (response.response.Text.length > 0) {
                    var EVAL_IS_BAD_AVOID_THIS = eval;
                    EVAL_IS_BAD_AVOID_THIS(JSON.parse(response.responseText))
                }
            }
        }
    }

    var constructSuccessCallBack = function (successCallBack) {
        return successCallBack || undefined
    };

    var constructErrorCallBack = function (errorCallBack) {
        return function (response) {
            self.defaultErrorcallback(response);
            if (errorCallBack) {
                errorCallBack(response)
            }
        }
    };

    self.post = function (url, data, successCallback, options) {
        options = options || {};
        data = data || {};
        var manageSpinner = options.manageSpinner === undefined ? true : options.manageSpinner;
        var async = options.async = undefined ? true : options.async;
        return $.ajax({ url: url, dataType: "json", contentType: "application/json", type: "POST", cache: false, data: data, async: async, success: constructSuccessCallBack(successCallback), error: constructErrorCallBack(options.error), complete: constructAjaxcompletecallBack(options, complete, manageSpinner) });
    };
};
