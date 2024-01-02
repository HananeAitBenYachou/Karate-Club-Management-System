using KarateClubBusinessLayer;

namespace KarateClub
{
    public class clsGlobalMember
    {
        private static clsMember _CurrentMember = clsMember.Find("", "");

        public static clsMember CurrentMember
        {
            set
            {
                _CurrentMember = value;
            }

            get
            {
                return _CurrentMember;
            }
        }

    }
}
