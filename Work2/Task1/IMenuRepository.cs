using System;
using System.Collections.Generic;
using System.Text;

namespace Work2
{
    interface IMenuRepository
    {
        /// <summary>
        /// Возвращает список пунктов меню, доступных пользователю.
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        IEnumerable<MenuItem> GetMenuItems(string username);
    }
}
