using UnityEngine;

namespace Framework
{
    public interface IServiceLocator<T>
    {
        /// <summary>
        /// 서비스를 등록합니다.
        /// </summary>
        bool Register<TItem>(TItem item) where TItem : T;

        /// <summary>
        /// 서비스를 해제합니다.
        /// </summary>
        bool UnRegister<TItem>(TItem item) where TItem : T;

        /// <summary>
        /// 등록된 서비스를 조회합니다.
        /// </summary>
        bool Get<TItem>(out TItem item) where TItem : T;

        /// <summary>
        /// 모든 서비스를 초기화합니다.
        /// </summary>
        bool Clear();
    }
}
