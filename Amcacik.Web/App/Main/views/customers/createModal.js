(function () {
    angular.module('app').controller('app.views.customers.createModal', [
        '$scope', '$uibModalInstance', 'abp.services.app.customer',
        function ($scope, $uibModalInstance, customerService) {
            var vm = this;

            vm.customer = {};

            vm.save = function () {
                customerService.create(vm.customer)
                    .then(function () {
                        abp.notify.info(App.localize('SavedSuccessfully'));
                        $uibModalInstance.close();
                    });
            };

            vm.cancel = function () {
                $uibModalInstance.dismiss({});
            };
            
        }
    ]);
})();