﻿#region Copyright (c) 2011-2016 Николай Морошкин, http://www.moroshkin.com/
/*

  Настоящий исходный код является частью приложения «Торговый привод QScalp»
  (http://www.qscalp.ru)  и  предоставлен  исключительно  в  ознакомительных
  целях.  Какое-либо коммерческое использование данного кода без письменного
  разрешения автора запрещено.

*/
#endregion

namespace QScalp.History
{
  // ************************************************************************

  enum StreamType
  {
    Quotes = 0x10,
    Deals = 0x20,
    OwnOrders = 0x30,
    OwnTrades = 0x40,
    Messages = 0x50,
    AuxInfo = 0x60,
    OrdLog = 0x70,
    None = 0
  }

  // ************************************************************************
}
