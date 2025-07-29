using System;
using UnityEngine.Localization.Settings;
using UniRx;

namespace UnityEngine.Localization
{
    /// <summary>
    /// ローカライズイベントをObservableとして提供するユーティリティクラス。
    /// </summary>
    public static class ObservableLocalizationEvent
    {
        /// <summary>
        /// 選択中のロケールが変更された際のイベントをObservableとして購読できるようにする。
        /// </summary>
        public static IObservable<Locale> SelectedLocaleChangedAsObservable()
        {
            return Observable.FromEvent<Locale>(
                h => LocalizationSettings.SelectedLocaleChanged += h,
                h => LocalizationSettings.SelectedLocaleChanged -= h
            );
        }
    }
}
