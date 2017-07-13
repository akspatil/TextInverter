var app = angular.module('TextInverterModule', []).config(function ($sceDelegateProvider) {
    $sceDelegateProvider.resourceUrlWhitelist([
        // Allow same origin resource loads.
        // Allow loading from our assets domain. **.
        'http://localhost:1438/**'
    ]);
});
app.config(['$qProvider', function ($qProvider) {
    $qProvider.errorOnUnhandledRejections(false);
}]);