using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AK.Common.Enums
{
    public static class PermissionEnums
    {
        public enum Modules
        {
            NONE,
            USER_CODE,
            USER_CODE_TYPE,
            USER_ACTIVITY,
            USER,
            USER_NOTIFY,
            USER_NOTIFY_TYPE,
            USER_PAGE_ACTION,
            USER_PAGE,
            USER_ROLE,
            USER_CONNECTION,
            USER_CONNECTION_TYPE,
            USER_KEY,
            TEMPLATE,
            PICTURE_TYPE,
            PICTURE,
            LOCATION_TYPE,
            LOCATION,
            FILE_TYPE,
            FILE,
            ARTICLE_TYPE,
            ARTICLE,
            ARTICLE_CATE,
            VIDEO,
        }

        public enum DefaultActions
        {
            NONE,
            ADMIN,
            OWNER,
            ACCESS,
            LIST,
            DATA,
            ADD,
            EDIT,
            DELETE
        }

        public enum UserActions
        {
            GET_INFO,
            UPDATE_INFO,
            CHANGE_PASSWORD,
            UPDATE_PASSWORD
        }               
    }
}
