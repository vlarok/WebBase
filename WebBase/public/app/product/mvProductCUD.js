angular.module('app').factory('mvProductCUD', function ($http, $q, mvProduct) {
    return {

        addOrUpdateProduct: function (newProductData) {
            var newProduct = new mvProduct(newProductData);
            var dfd = $q.defer();
            newProduct.$addOrUpdate().then(function (response) {
                dfd.resolve(response);
            }, function (response) {
                dfd.reject(response.data.reason);
            });
            return dfd.promise;
        },
        
        deleteProduct: function (deleteProductData) {
            var deleteProduct = new mvProduct(deleteProductData);
            console.log(deleteProduct);
            var dfd = $q.defer();
            deleteProduct.$delete_product().then(function (response) {
                dfd.resolve(response);
            }, function (response) {
                dfd.reject(response.data.reason);
            });
            return dfd.promise;
           
         
            }

    }
});