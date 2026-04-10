using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class TaskUIManager : MonoBehaviour
{
    public static TaskUIManager Instance;

    public GameObject taskItemPrefab;
    public Transform taskListParent;

    private Dictionary<Task, GameObject> taskUIMap = new Dictionary<Task, GameObject>();

    void Awake()
    {
        Instance = this;
    }

    public void AddTask(Task task)
    {
        GameObject uiItem = Instantiate(taskItemPrefab, taskListParent);

        TextMeshProUGUI text = uiItem.GetComponent<TextMeshProUGUI>();
        text.text = task.taskName;

        taskUIMap.Add(task, uiItem);
    }

    public void RemoveTask(Task task)
    {
        if (taskUIMap.ContainsKey(task))
        {
            Destroy(taskUIMap[task]);
            taskUIMap.Remove(task);
        }
    }
}