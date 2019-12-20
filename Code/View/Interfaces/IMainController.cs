using Transports.Forms;

namespace Transports.Code.View
{
    interface IMainController
    {
        void Init(Main form);

        void ShowMessage(string message);
    }
}
