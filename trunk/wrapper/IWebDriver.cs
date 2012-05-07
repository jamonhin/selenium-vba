﻿using System;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace SeleniumWrapper
{
    [Guid("24cd39f2-f552-4a61-82fe-cc6284398aa5"), InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IWebDriver
    {
        [Description("Specifies the amount of time the driver should wait when searching for an element if it is not immediately present.")]
        void setImplicitWait(int timeout_ms);

        [Description("Starts a new Selenium session")]
        void start(String browser, String url, [Optional][DefaultParameterValue("")]String serverPath);

        [Description("Starts remotely a new Selenium session")]
        void startRemotely(String browser, String remoteAddress, String url, [Optional][DefaultParameterValue(true)]Boolean javascriptEnabled, [Optional][DefaultParameterValue("")]String capabilities);

        [Description("Wait the specified time in millisecond before executing the next command")]
        void wait(int time_ms);

        [Description("Wait the specified time in millisecond before executing the next command")]
        void pause(int time_ms);

        [Description("Returns a string with the result of the verification ( <OK> or <KO, ...> )")]
        String verifyEqual(Object expected, Object current);

        [Description("Returns a string with the result of the verification ( <OK> or <KO, ...> )")]
        String verifyNotEqual(Object expected, Object current);

        [Description("Raise an error if the assertion fails")]
        void assertEqual(Object expected, Object current);

        [Description("Raise an error if the assertion fails")]
        void assertNotEqual(Object expected, Object current);

        [Description("Capture a screenshot to the Clipboard")]
        void captureScreenshotToClipboard();

        [Description("Execute JavaScrip on the page")]
		Object executeScript(String script, [Optional][DefaultParameterValue(null)]Object arguments);

		#region Auto-Generated Code
		void waitForPageToLoad(String timeout);
		void waitForFrameToLoad(String frameAddress, String timeout);
		String getCookie();
		void assertCookie(String expected);
		void assertNotCookie(String expected);
		String verifyCookie(String expected);
		String verifyNotCookie(String expected);
		void waitForCookie(String expected);
		void waitForNotCookie(String expected);
		String getCookieByName(String name);
		void assertCookieByName(String name, String expected);
		void assertNotCookieByName(String name, String expected);
		String verifyCookieByName(String name, String expected);
		String verifyNotCookieByName(String name, String expected);
		void waitForCookieByName(String name, String expected);
		void waitForNotCookieByName(String name, String expected);
		Boolean isCookiePresent(String name);
		void assertCookiePresent(String name);
		String verifyCookiePresent(String name);
		void waitForCookiePresent(String name);
		void assertCookieNotPresent(String name);
		String verifyCookieNotPresent(String name);
		void waitForCookieNotPresent(String name);
		void createCookie(String nameValuePair, String optionsString);
		void createCookieAndWait(String nameValuePair, String optionsString);
		void deleteCookie(String name, String optionsString);
		void deleteAllVisibleCookies();
		void setBrowserLogLevel(String logLevel);
		void runScript(String script);
		void runScriptAndWait(String script);
		void addLocationStrategy(String strategyName, String functionDefinition);
		void addLocationStrategyAndWait(String strategyName, String functionDefinition);
		void captureEntirePageScreenshot(String filename, String kwargs);
		void rollup(String rollupName, String kwargs);
		void rollupAndWait(String rollupName, String kwargs);
		void addScript(String scriptContent, String scriptTagId);
		void addScriptAndWait(String scriptContent, String scriptTagId);
		void removeScript(String scriptTagId);
		void removeScriptAndWait(String scriptTagId);
		void useXpathLibrary(String libraryName);
		void useXpathLibraryAndWait(String libraryName);
		void setContext(String context);
		void attachFile(String fieldLocator, String fileLocator);
		void attachFileAndWait(String fieldLocator, String fileLocator);
		void captureScreenshot(String filename);
		String captureScreenshotToString();
		String captureNetworkTraffic(String type);
		String captureEntirePageScreenshotToString(String kwargs);
		void shutDownSeleniumServer();
		void shutDownSeleniumServerAndWait();
		String retrieveLastRemoteControlLogs();
		void keyDownNative(String keycode);
		void keyDownNativeAndWait(String keycode);
		void keyUpNative(String keycode);
		void keyUpNativeAndWait(String keycode);
		void keyPressNative(String keycode);
		void keyPressNativeAndWait(String keycode);
		void setExtensionJs(String extensionJs);
		void stop();
		void click(String locator);
		void clickAndWait(String locator);
		void doubleClick(String locator);
		void doubleClickAndWait(String locator);
		void contextMenu(String locator);
		void contextMenuAndWait(String locator);
		void clickAt(String locator, String coordString);
		void clickAtAndWait(String locator, String coordString);
		void doubleClickAt(String locator, String coordString);
		void doubleClickAtAndWait(String locator, String coordString);
		void contextMenuAt(String locator, String coordString);
		void contextMenuAtAndWait(String locator, String coordString);
		void fireEvent(String locator, String eventName);
		void fireEventAndWait(String locator, String eventName);
		void focus(String locator);
		void focusAndWait(String locator);
		void keyPress(String locator, String keySequence);
		void keyPressAndWait(String locator, String keySequence);
		void shiftKeyDown();
		void shiftKeyDownAndWait();
		void shiftKeyUp();
		void shiftKeyUpAndWait();
		void metaKeyDown();
		void metaKeyDownAndWait();
		void metaKeyUp();
		void metaKeyUpAndWait();
		void altKeyDown();
		void altKeyDownAndWait();
		void altKeyUp();
		void altKeyUpAndWait();
		void controlKeyDown();
		void controlKeyDownAndWait();
		void controlKeyUp();
		void controlKeyUpAndWait();
		void keyDown(String locator, String keySequence);
		void keyDownAndWait(String locator, String keySequence);
		void keyUp(String locator, String keySequence);
		void keyUpAndWait(String locator, String keySequence);
		void mouseOver(String locator);
		void mouseOverAndWait(String locator);
		void mouseOut(String locator);
		void mouseOutAndWait(String locator);
		void mouseDown(String locator);
		void mouseDownAndWait(String locator);
		void mouseDownRight(String locator);
		void mouseDownRightAndWait(String locator);
		void mouseDownAt(String locator, String coordString);
		void mouseDownAtAndWait(String locator, String coordString);
		void mouseDownRightAt(String locator, String coordString);
		void mouseDownRightAtAndWait(String locator, String coordString);
		void mouseUp(String locator);
		void mouseUpAndWait(String locator);
		void mouseUpRight(String locator);
		void mouseUpRightAndWait(String locator);
		void mouseUpAt(String locator, String coordString);
		void mouseUpAtAndWait(String locator, String coordString);
		void mouseUpRightAt(String locator, String coordString);
		void mouseUpRightAtAndWait(String locator, String coordString);
		void mouseMove(String locator);
		void mouseMoveAndWait(String locator);
		void mouseMoveAt(String locator, String coordString);
		void mouseMoveAtAndWait(String locator, String coordString);
		void type(String locator, String value);
		void typeAndWait(String locator, String value);
		void typeKeys(String locator, String value);
		void typeKeysAndWait(String locator, String value);
		void setSpeed(String value);
		String getSpeed();
		void assertSpeed(String expected);
		void assertNotSpeed(String expected);
		String verifySpeed(String expected);
		String verifyNotSpeed(String expected);
		void waitForSpeed(String expected);
		void waitForNotSpeed(String expected);
		void check(String locator);
		void checkAndWait(String locator);
		void uncheck(String locator);
		void uncheckAndWait(String locator);
		void select(String selectLocator, String optionLocator);
		void selectAndWait(String selectLocator, String optionLocator);
		void addSelection(String locator, String optionLocator);
		void addSelectionAndWait(String locator, String optionLocator);
		void removeSelection(String locator, String optionLocator);
		void removeSelectionAndWait(String locator, String optionLocator);
		void removeAllSelections(String locator);
		void removeAllSelectionsAndWait(String locator);
		void submit(String formLocator);
		void submitAndWait(String formLocator);
		void open(String url);
		void openWindow(String url, String windowID);
		void selectWindow(String windowID);
		void selectPopUp(String windowID);
		void selectPopUpAndWait(String windowID);
		void deselectPopUp();
		void deselectPopUpAndWait();
		void selectFrame(String locator);
		Boolean getWhetherThisFrameMatchFrameExpression(String currentFrameString, String target);
		void assertWhetherThisFrameMatchFrameExpression(String currentFrameString, String target, Boolean expected);
		void assertNotWhetherThisFrameMatchFrameExpression(String currentFrameString, String target, Boolean expected);
		String verifyWhetherThisFrameMatchFrameExpression(String currentFrameString, String target, Boolean expected);
		String verifyNotWhetherThisFrameMatchFrameExpression(String currentFrameString, String target, Boolean expected);
		void waitForWhetherThisFrameMatchFrameExpression(String currentFrameString, String target, Boolean expected);
		void waitForNotWhetherThisFrameMatchFrameExpression(String currentFrameString, String target, Boolean expected);
		Boolean getWhetherThisWindowMatchWindowExpression(String currentWindowString, String target);
		void assertWhetherThisWindowMatchWindowExpression(String currentWindowString, String target, Boolean expected);
		void assertNotWhetherThisWindowMatchWindowExpression(String currentWindowString, String target, Boolean expected);
		String verifyWhetherThisWindowMatchWindowExpression(String currentWindowString, String target, Boolean expected);
		String verifyNotWhetherThisWindowMatchWindowExpression(String currentWindowString, String target, Boolean expected);
		void waitForWhetherThisWindowMatchWindowExpression(String currentWindowString, String target, Boolean expected);
		void waitForNotWhetherThisWindowMatchWindowExpression(String currentWindowString, String target, Boolean expected);
		void waitForPopUp(String windowID, String timeout);
		void chooseCancelOnNextConfirmation();
		void chooseOkOnNextConfirmation();
		void chooseOkOnNextConfirmationAndWait();
		void answerOnNextPrompt(String answer);
		void goBack();
		void goBackAndWait();
		void refresh();
		void refreshAndWait();
		void close();
		Boolean isAlertPresent();
		void assertAlertPresent();
		String verifyAlertPresent();
		void waitForAlertPresent();
		void assertAlertNotPresent();
		String verifyAlertNotPresent();
		void waitForAlertNotPresent();
		Boolean isPromptPresent();
		void assertPromptPresent();
		String verifyPromptPresent();
		void waitForPromptPresent();
		void assertPromptNotPresent();
		String verifyPromptNotPresent();
		void waitForPromptNotPresent();
		Boolean isConfirmationPresent();
		void assertConfirmationPresent();
		String verifyConfirmationPresent();
		void waitForConfirmationPresent();
		void assertConfirmationNotPresent();
		String verifyConfirmationNotPresent();
		void waitForConfirmationNotPresent();
		String getAlert();
		void assertAlert(String expected);
		void assertNotAlert(String expected);
		String verifyAlert(String expected);
		String verifyNotAlert(String expected);
		void waitForAlert(String expected);
		void waitForNotAlert(String expected);
		String getConfirmation();
		void assertConfirmation(String expected);
		void assertNotConfirmation(String expected);
		String verifyConfirmation(String expected);
		String verifyNotConfirmation(String expected);
		void waitForConfirmation(String expected);
		void waitForNotConfirmation(String expected);
		String getPrompt();
		void assertPrompt(String expected);
		void assertNotPrompt(String expected);
		String verifyPrompt(String expected);
		String verifyNotPrompt(String expected);
		void waitForPrompt(String expected);
		void waitForNotPrompt(String expected);
		String getLocation();
		void assertLocation(String expected);
		void assertNotLocation(String expected);
		String verifyLocation(String expected);
		String verifyNotLocation(String expected);
		void waitForLocation(String expected);
		void waitForNotLocation(String expected);
		String getTitle();
		void assertTitle(String expected);
		void assertNotTitle(String expected);
		String verifyTitle(String expected);
		String verifyNotTitle(String expected);
		void waitForTitle(String expected);
		void waitForNotTitle(String expected);
		String getBodyText();
		void assertBodyText(String expected);
		void assertNotBodyText(String expected);
		String verifyBodyText(String expected);
		String verifyNotBodyText(String expected);
		void waitForBodyText(String expected);
		void waitForNotBodyText(String expected);
		String getValue(String locator);
		void assertValue(String locator, String expected);
		void assertNotValue(String locator, String expected);
		String verifyValue(String locator, String expected);
		String verifyNotValue(String locator, String expected);
		void waitForValue(String locator, String expected);
		void waitForNotValue(String locator, String expected);
		String getText(String locator);
		void assertText(String locator, String expected);
		void assertNotText(String locator, String expected);
		String verifyText(String locator, String expected);
		String verifyNotText(String locator, String expected);
		void waitForText(String locator, String expected);
		void waitForNotText(String locator, String expected);
		void highlight(String locator);
		void highlightAndWait(String locator);
		String getEval(String script);
		void assertEval(String script, String expected);
		void assertNotEval(String script, String expected);
		String verifyEval(String script, String expected);
		String verifyNotEval(String script, String expected);
		void waitForEval(String script, String expected);
		void waitForNotEval(String script, String expected);
		Boolean isChecked(String locator);
		void assertChecked(String locator);
		String verifyChecked(String locator);
		void waitForChecked(String locator);
		void assertNotChecked(String locator);
		String verifyNotChecked(String locator);
		void waitForNotChecked(String locator);
		String getTable(String tableCellAddress);
		void assertTable(String tableCellAddress, String expected);
		void assertNotTable(String tableCellAddress, String expected);
		String verifyTable(String tableCellAddress, String expected);
		String verifyNotTable(String tableCellAddress, String expected);
		void waitForTable(String tableCellAddress, String expected);
		void waitForNotTable(String tableCellAddress, String expected);
		String[] getSelectedLabels(String selectLocator);
		void assertSelectedLabels(String selectLocator, String[] expected);
		void assertNotSelectedLabels(String selectLocator, String[] expected);
		String verifySelectedLabels(String selectLocator, String[] expected);
		String verifyNotSelectedLabels(String selectLocator, String[] expected);
		void waitForSelectedLabels(String selectLocator, String[] expected);
		void waitForNotSelectedLabels(String selectLocator, String[] expected);
		String getSelectedLabel(String selectLocator);
		void assertSelectedLabel(String selectLocator, String expected);
		void assertNotSelectedLabel(String selectLocator, String expected);
		String verifySelectedLabel(String selectLocator, String expected);
		String verifyNotSelectedLabel(String selectLocator, String expected);
		void waitForSelectedLabel(String selectLocator, String expected);
		void waitForNotSelectedLabel(String selectLocator, String expected);
		String[] getSelectedValues(String selectLocator);
		void assertSelectedValues(String selectLocator, String[] expected);
		void assertNotSelectedValues(String selectLocator, String[] expected);
		String verifySelectedValues(String selectLocator, String[] expected);
		String verifyNotSelectedValues(String selectLocator, String[] expected);
		void waitForSelectedValues(String selectLocator, String[] expected);
		void waitForNotSelectedValues(String selectLocator, String[] expected);
		String getSelectedValue(String selectLocator);
		void assertSelectedValue(String selectLocator, String expected);
		void assertNotSelectedValue(String selectLocator, String expected);
		String verifySelectedValue(String selectLocator, String expected);
		String verifyNotSelectedValue(String selectLocator, String expected);
		void waitForSelectedValue(String selectLocator, String expected);
		void waitForNotSelectedValue(String selectLocator, String expected);
		String[] getSelectedIndexes(String selectLocator);
		void assertSelectedIndexes(String selectLocator, String[] expected);
		void assertNotSelectedIndexes(String selectLocator, String[] expected);
		String verifySelectedIndexes(String selectLocator, String[] expected);
		String verifyNotSelectedIndexes(String selectLocator, String[] expected);
		void waitForSelectedIndexes(String selectLocator, String[] expected);
		void waitForNotSelectedIndexes(String selectLocator, String[] expected);
		String getSelectedIndex(String selectLocator);
		void assertSelectedIndex(String selectLocator, String expected);
		void assertNotSelectedIndex(String selectLocator, String expected);
		String verifySelectedIndex(String selectLocator, String expected);
		String verifyNotSelectedIndex(String selectLocator, String expected);
		void waitForSelectedIndex(String selectLocator, String expected);
		void waitForNotSelectedIndex(String selectLocator, String expected);
		String[] getSelectedIds(String selectLocator);
		void assertSelectedIds(String selectLocator, String[] expected);
		void assertNotSelectedIds(String selectLocator, String[] expected);
		String verifySelectedIds(String selectLocator, String[] expected);
		String verifyNotSelectedIds(String selectLocator, String[] expected);
		void waitForSelectedIds(String selectLocator, String[] expected);
		void waitForNotSelectedIds(String selectLocator, String[] expected);
		String getSelectedId(String selectLocator);
		void assertSelectedId(String selectLocator, String expected);
		void assertNotSelectedId(String selectLocator, String expected);
		String verifySelectedId(String selectLocator, String expected);
		String verifyNotSelectedId(String selectLocator, String expected);
		void waitForSelectedId(String selectLocator, String expected);
		void waitForNotSelectedId(String selectLocator, String expected);
		Boolean isSomethingSelected(String selectLocator);
		void assertSomethingSelected(String selectLocator);
		String verifySomethingSelected(String selectLocator);
		void waitForSomethingSelected(String selectLocator);
		void assertNotSomethingSelected(String selectLocator);
		String verifyNotSomethingSelected(String selectLocator);
		void waitForNotSomethingSelected(String selectLocator);
		String[] getSelectOptions(String selectLocator);
		void assertSelectOptions(String selectLocator, String[] expected);
		void assertNotSelectOptions(String selectLocator, String[] expected);
		String verifySelectOptions(String selectLocator, String[] expected);
		String verifyNotSelectOptions(String selectLocator, String[] expected);
		void waitForSelectOptions(String selectLocator, String[] expected);
		void waitForNotSelectOptions(String selectLocator, String[] expected);
		String getAttribute(String attributeLocator);
		void assertAttribute(String attributeLocator, String expected);
		void assertNotAttribute(String attributeLocator, String expected);
		String verifyAttribute(String attributeLocator, String expected);
		String verifyNotAttribute(String attributeLocator, String expected);
		void waitForAttribute(String attributeLocator, String expected);
		void waitForNotAttribute(String attributeLocator, String expected);
		Boolean isTextPresent(String pattern);
		void assertTextPresent(String pattern);
		String verifyTextPresent(String pattern);
		void waitForTextPresent(String pattern);
		void assertTextNotPresent(String pattern);
		String verifyTextNotPresent(String pattern);
		void waitForTextNotPresent(String pattern);
		Boolean isElementPresent(String locator);
		void assertElementPresent(String locator);
		String verifyElementPresent(String locator);
		void waitForElementPresent(String locator);
		void assertElementNotPresent(String locator);
		String verifyElementNotPresent(String locator);
		void waitForElementNotPresent(String locator);
		Boolean isVisible(String locator);
		void assertVisible(String locator);
		String verifyVisible(String locator);
		void waitForVisible(String locator);
		void assertNotVisible(String locator);
		String verifyNotVisible(String locator);
		void waitForNotVisible(String locator);
		Boolean isEditable(String locator);
		void assertEditable(String locator);
		String verifyEditable(String locator);
		void waitForEditable(String locator);
		void assertNotEditable(String locator);
		String verifyNotEditable(String locator);
		void waitForNotEditable(String locator);
		String[] getAllButtons();
		void assertAllButtons(String[] expected);
		void assertNotAllButtons(String[] expected);
		String verifyAllButtons(String[] expected);
		String verifyNotAllButtons(String[] expected);
		void waitForAllButtons(String[] expected);
		void waitForNotAllButtons(String[] expected);
		String[] getAllLinks();
		void assertAllLinks(String[] expected);
		void assertNotAllLinks(String[] expected);
		String verifyAllLinks(String[] expected);
		String verifyNotAllLinks(String[] expected);
		void waitForAllLinks(String[] expected);
		void waitForNotAllLinks(String[] expected);
		String[] getAllFields();
		void assertAllFields(String[] expected);
		void assertNotAllFields(String[] expected);
		String verifyAllFields(String[] expected);
		String verifyNotAllFields(String[] expected);
		void waitForAllFields(String[] expected);
		void waitForNotAllFields(String[] expected);
		String[] getAttributeFromAllWindows(String attributeName);
		void assertAttributeFromAllWindows(String attributeName, String[] expected);
		void assertNotAttributeFromAllWindows(String attributeName, String[] expected);
		String verifyAttributeFromAllWindows(String attributeName, String[] expected);
		String verifyNotAttributeFromAllWindows(String attributeName, String[] expected);
		void waitForAttributeFromAllWindows(String attributeName, String[] expected);
		void waitForNotAttributeFromAllWindows(String attributeName, String[] expected);
		void dragdrop(String locator, String movementsString);
		void dragdropAndWait(String locator, String movementsString);
		void setMouseSpeed(String pixels);
		Decimal getMouseSpeed();
		void assertMouseSpeed(Decimal expected);
		void assertNotMouseSpeed(Decimal expected);
		String verifyMouseSpeed(Decimal expected);
		String verifyNotMouseSpeed(Decimal expected);
		void waitForMouseSpeed(Decimal expected);
		void waitForNotMouseSpeed(Decimal expected);
		void dragAndDrop(String locator, String movementsString);
		void dragAndDropAndWait(String locator, String movementsString);
		void dragAndDropToObject(String locatorOfObjectToBeDragged, String locatorOfDragDestinationObject);
		void dragAndDropToObjectAndWait(String locatorOfObjectToBeDragged, String locatorOfDragDestinationObject);
		void windowFocus();
		void windowFocusAndWait();
		void windowMaximize();
		void windowMaximizeAndWait();
		String[] getAllWindowIds();
		void assertAllWindowIds(String[] expected);
		void assertNotAllWindowIds(String[] expected);
		String verifyAllWindowIds(String[] expected);
		String verifyNotAllWindowIds(String[] expected);
		void waitForAllWindowIds(String[] expected);
		void waitForNotAllWindowIds(String[] expected);
		String[] getAllWindowNames();
		void assertAllWindowNames(String[] expected);
		void assertNotAllWindowNames(String[] expected);
		String verifyAllWindowNames(String[] expected);
		String verifyNotAllWindowNames(String[] expected);
		void waitForAllWindowNames(String[] expected);
		void waitForNotAllWindowNames(String[] expected);
		String[] getAllWindowTitles();
		void assertAllWindowTitles(String[] expected);
		void assertNotAllWindowTitles(String[] expected);
		String verifyAllWindowTitles(String[] expected);
		String verifyNotAllWindowTitles(String[] expected);
		void waitForAllWindowTitles(String[] expected);
		void waitForNotAllWindowTitles(String[] expected);
		String getHtmlSource();
		void assertHtmlSource(String expected);
		void assertNotHtmlSource(String expected);
		String verifyHtmlSource(String expected);
		String verifyNotHtmlSource(String expected);
		void waitForHtmlSource(String expected);
		void waitForNotHtmlSource(String expected);
		void setCursorPosition(String locator, String position);
		Decimal getElementIndex(String locator);
		void assertElementIndex(String locator, Decimal expected);
		void assertNotElementIndex(String locator, Decimal expected);
		String verifyElementIndex(String locator, Decimal expected);
		String verifyNotElementIndex(String locator, Decimal expected);
		void waitForElementIndex(String locator, Decimal expected);
		void waitForNotElementIndex(String locator, Decimal expected);
		Boolean isOrdered(String locator1, String locator2);
		void assertOrdered(String locator1, String locator2);
		String verifyOrdered(String locator1, String locator2);
		void waitForOrdered(String locator1, String locator2);
		void assertNotOrdered(String locator1, String locator2);
		String verifyNotOrdered(String locator1, String locator2);
		void waitForNotOrdered(String locator1, String locator2);
		Decimal getElementPositionLeft(String locator);
		void assertElementPositionLeft(String locator, Decimal expected);
		void assertNotElementPositionLeft(String locator, Decimal expected);
		String verifyElementPositionLeft(String locator, Decimal expected);
		String verifyNotElementPositionLeft(String locator, Decimal expected);
		void waitForElementPositionLeft(String locator, Decimal expected);
		void waitForNotElementPositionLeft(String locator, Decimal expected);
		Decimal getElementPositionTop(String locator);
		void assertElementPositionTop(String locator, Decimal expected);
		void assertNotElementPositionTop(String locator, Decimal expected);
		String verifyElementPositionTop(String locator, Decimal expected);
		String verifyNotElementPositionTop(String locator, Decimal expected);
		void waitForElementPositionTop(String locator, Decimal expected);
		void waitForNotElementPositionTop(String locator, Decimal expected);
		Decimal getElementWidth(String locator);
		void assertElementWidth(String locator, Decimal expected);
		void assertNotElementWidth(String locator, Decimal expected);
		String verifyElementWidth(String locator, Decimal expected);
		String verifyNotElementWidth(String locator, Decimal expected);
		void waitForElementWidth(String locator, Decimal expected);
		void waitForNotElementWidth(String locator, Decimal expected);
		Decimal getElementHeight(String locator);
		void assertElementHeight(String locator, Decimal expected);
		void assertNotElementHeight(String locator, Decimal expected);
		String verifyElementHeight(String locator, Decimal expected);
		String verifyNotElementHeight(String locator, Decimal expected);
		void waitForElementHeight(String locator, Decimal expected);
		void waitForNotElementHeight(String locator, Decimal expected);
		Decimal getCursorPosition(String locator);
		void assertCursorPosition(String locator, Decimal expected);
		void assertNotCursorPosition(String locator, Decimal expected);
		String verifyCursorPosition(String locator, Decimal expected);
		String verifyNotCursorPosition(String locator, Decimal expected);
		void waitForCursorPosition(String locator, Decimal expected);
		void waitForNotCursorPosition(String locator, Decimal expected);
		String getExpression(String expression);
		void assertExpression(String expression, String expected);
		void assertNotExpression(String expression, String expected);
		String verifyExpression(String expression, String expected);
		String verifyNotExpression(String expression, String expected);
		void waitForExpression(String expression, String expected);
		void waitForNotExpression(String expression, String expected);
		Decimal getXpathCount(String xpath);
		void assertXpathCount(String xpath, Decimal expected);
		void assertNotXpathCount(String xpath, Decimal expected);
		String verifyXpathCount(String xpath, Decimal expected);
		String verifyNotXpathCount(String xpath, Decimal expected);
		void waitForXpathCount(String xpath, Decimal expected);
		void waitForNotXpathCount(String xpath, Decimal expected);
		Decimal getCssCount(String cssLocator);
		void assertCssCount(String cssLocator, Decimal expected);
		void assertNotCssCount(String cssLocator, Decimal expected);
		String verifyCssCount(String cssLocator, Decimal expected);
		String verifyNotCssCount(String cssLocator, Decimal expected);
		void waitForCssCount(String cssLocator, Decimal expected);
		void waitForNotCssCount(String cssLocator, Decimal expected);
		void assignId(String locator, String identifier);
		void assignIdAndWait(String locator, String identifier);
		void allowNativeXpath(String allow);
		void allowNativeXpathAndWait(String allow);
		void ignoreAttributesWithoutValue(String ignore);
		void ignoreAttributesWithoutValueAndWait(String ignore);
		void waitForCondition(String script, String timeout);
		#endregion


    }
}
