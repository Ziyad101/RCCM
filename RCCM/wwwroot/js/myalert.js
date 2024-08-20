// myAlert.js
$(document).ready(function () {
    class FormAlertHandler {
        constructor(formId, alertId, alertClass, message) {
            this.form = $(formId);
            this.successAlert = $(alertId);
            this.alertMessage = this.successAlert.find('.alert-message');
            this.message = message;
            this.alertClass = alertClass;

            this.init();
        }

        init() {
            this.form.on('submit', (event) => {
                event.preventDefault(); // Prevent default form submission

                // Show success alert
                this.successAlert.removeClass('d-none').addClass(this.alertClass);
                this.alertMessage.text(this.message);

                // Simulate a delay before redirecting
                setTimeout(() => {
                    this.form.off('submit').submit(); // Unbind event handler and submit form programmatically after delay
                }, 2000); // 2 seconds delay
            });
        }
    }

    // Initialize FormAlertHandler for different forms
    new FormAlertHandler('#addUserForm', '#successAlert', 'alert-success', 'تم إضافتها بنجاح!');
    new FormAlertHandler('#editUserForm', '#successAlert', 'alert-warning', 'تم تحديث بيانات بنجاح!');
    new FormAlertHandler('#deleteUserForm', '#successAlert', 'alert-danger', 'تم حذفها بنجاح!');
});
