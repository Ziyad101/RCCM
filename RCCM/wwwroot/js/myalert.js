// myAlert.js
$(document).ready(function () {
    class FormAlertHandler {
        constructor(formId, alertId, message) {
            this.form = $(formId);
            this.successAlert = $(alertId);
            this.alertMessage = this.successAlert.find('.alert-message');
            this.message = message;

            this.init();
        }

        init() {
            this.form.on('submit', (event) => {
                event.preventDefault(); // Prevent default form submission

                // Show success alert
                this.alertMessage.text(this.message);
                this.successAlert.removeClass('d-none');

                // Simulate a delay before redirecting
                setTimeout(() => {
                    this.form.off('submit').submit(); // Unbind event handler and submit form programmatically after delay
                }, 2000); // 2 seconds delay
            });
        }
    }

    // Initialize FormAlertHandler for each form
    new FormAlertHandler('#addGradeForm', '#successAlert', ' تم إضافتها بنجاح!');
    new FormAlertHandler('#editGradeForm', '#successAlert', 'تم تحديث بيانات  بنجاح!');
    new FormAlertHandler('#deleteGradeForm', '#successAlert', ' تم حذفها بنجاح!');
});
