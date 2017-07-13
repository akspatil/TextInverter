app.service('TextInverterService', function ($http, $sce, $q) {
    this.post = function (data) {
        var deferred = $q.defer();
        console.log(deferred.promise.$$state.status);
        var src = 'http://localhost:1438/Service1.svc/ReverseEachWord';
        var url = $sce.trustAsResourceUrl(src);
        var data = $.param({
            input: data
        });
        var config = {
            headers: { 'Content-Type': 'application/json' }
        }
        return $http.post(url, data, config);
        //return deferred.promise;
    }
})